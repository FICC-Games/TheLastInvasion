using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymelee : MonoBehaviour
{
    private GameObject enemy;

    Rigidbody2D rb;

    Player target;

    public float health = 3;
    public float healthTimer;

    public void GiveDamage(int damage)
    {
        target.playerhealth -= damage;

        if (target.playerhealth < 000.1)
        {
            Die();
        }


    }
    void Die()
    {
       Destroy(target.gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bullet")
        {

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            if (healthTimer > 2)
            {
                healthTimer = 0;
                health -= 1;
                Destroy(collision.gameObject);
            }
        }
    }
}
// made by Efe