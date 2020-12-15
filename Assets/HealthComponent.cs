using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthComponent : MonoBehaviour
{
    public Slider healthslider;
    public float maxHealth;
    public static float currentHealth;
    //This method provides collision data for the enemies that collide with the player
    void OnCollisionEnter(Collision collision)
    {
        //This is the enemy in which it collided with the player
        Enemy other = collision.gameObject.GetComponent<Enemy>();
        if (other)
        {
            //If the enemy collided with the player, then the player loses health
            currentHealth -= other.damage;
            healthslider.value = currentHealth;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        //If the player's health is at or below 0,...
        healthslider.value = currentHealth;
        
    }
}
