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
    //searching for player.
    void Start()
    {
        playerTransform = FindObjectOfType<Movment>().transform;
    }

    // Update is called once per frame
    // enemy raycast to to follow the player.
    void Update()
    {
        directionToPlayer = (playerTransform.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, directionToPlayer, 500);
        Debug.DrawRay(transform.position, directionToPlayer * 500);
        if (hit.transform != null)
        {
            print("träffad");
            if (hit.transform.tag == "Player")
            {
                print("hittad");
                transform.position += directionToPlayer * 1 * Time.deltaTime;
            }


        }


    }
   
}
// made by Efe