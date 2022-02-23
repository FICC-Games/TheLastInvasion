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


    // to make sure there is collision.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bullet")
        {

        }
    }
   // being able to take damage when colllidiing.
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