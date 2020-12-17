using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthComponent : MonoBehaviour
{
    public Slider healthslider;
    public float maxHealth;
    public static float currentHealth;
    public float damage = 20f;
    public GameObject DeathCanvas;
    // Start is called before the first frame update
    void Start()
    {
        healthslider.value = maxHealth;
        currentHealth = maxHealth;
        print(healthslider.value);
        DeathCanvas.SetActive(false);
    }

    //This method provides collision data for the enemies that collide with the player
    void OnCollisionEnter(Collision collision)
    {
        //This is the enemy in which it collided with the player
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //If the enemy collided with the player, then the player loses health
            currentHealth -= damage;
            healthslider.value = currentHealth;
            print(healthslider.value);
            Debug.Log("Im colliding");
        }

        if(healthslider.value <= 0)
        {
            DeathCanvas.SetActive(true);
            Cursor.visible = true;
        }
    }
}
