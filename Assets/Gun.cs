using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float firerate = 15f;
    public float maxammo=10f;
    public float currentammo;

    public Camera fpsCam;
    private float nextTimetoFire = 0f;
    // Update is called once per frame
    private void Start()
    {
        currentammo = maxammo;  
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimetoFire) 
        {
            nextTimetoFire = Time.time + 1f / firerate;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy target= hit.transform.GetComponent<Enemy>();
            if (target != null) {
                target.TakeDamage(damage);
                currentammo--;
            }
        }

    }
}
