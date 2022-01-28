using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyraycast : MonoBehaviour
{

    Vector3 directionToPlayer;
    Transform playerTransform;
    [SerializeField]
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //playerTransform = FindObjectOfType<Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        directionToPlayer = (playerTransform.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, directionToPlayer, 5);
        if (hit.transform != null)
        {

            if (hit.transform.tag == "player")
            {
                transform.position += directionToPlayer * 1 * Time.deltaTime;
            }


        }


    }
   
}
