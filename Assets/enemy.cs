using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D rb;

    public int health = 3;

    float speed = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "hit")
        {
            TakeDamage(3);
        }
    }

    public void TakeDamage(int damage)
    {
        health = -damage;

        if (health < 1)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
   
}
// made by Efe