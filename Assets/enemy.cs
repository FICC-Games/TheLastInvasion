using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   
    public float speed; 
    public GameObject Enemy;
    public int health = 9;

    // enemy being able to take damage.
    public void TakeDamage(int damage)
    {
        health =-damage;

        if (health < 1)
        {
            Die();
        }
    }
    // enemy being able to die.
    void Die()
    {
        Destroy(gameObject);
    }
   
}
// made by Efe