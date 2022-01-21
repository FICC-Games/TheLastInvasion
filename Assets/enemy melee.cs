using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymelee : MonoBehaviour
{
    Rigidbody2D rb;

    Player target;

    public int playerhealth;

    public void GiveDamage(int damage)
    {
        playerhealth -= damage;

        if (playerhealth < 000.1)
        {
            Die();
        }


    }
    void Die()
    {
        Destroy(Player);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bullet")
        {

        }
    }
}
