
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;

    public GameObject target;

    public float health = 50f;
    public float agentDistanceRun = 4.0f;
    public float damage = 10f;
    public void TakeDamage(float amount) {

        health -= amount;
        if (health <= 0f)
        {
            Die();       
        }
            }
    void Die() {
        Destroy(gameObject);
    }

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.transform.position);

        //Run towards player
        if(distance < agentDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - target.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            agent.SetDestination(newPos);
        }
    }

}
