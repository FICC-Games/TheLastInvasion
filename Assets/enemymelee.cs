using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymelee : MonoBehaviour
{
    private GameObject enemy;

    Rigidbody2D rb;

    Player target;

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
}
// made by Efe