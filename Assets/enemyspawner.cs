using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    private GameObject newenemy;
    private int randomSpawnZone;
    private float randomXposition, randomYposition;
    private Vector3 spawnposition;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnenemy", 100f, 100f);
    }



    private void spawnenemy()
    {
        randomSpawnZone = Random.Range(-5, 4);
        switch (randomSpawnZone)
        {
            case 0:
                randomXposition = Random.Range(-3f, 8f);
                randomYposition = Random.Range(0f, 0f);
                break;
            case 1:
                randomXposition = Random.Range(-5f, 1f);
                randomYposition = Random.Range(0f, 0f);
                break;
            case 2:
                randomXposition = Random.Range(-2f, 0f);
                randomYposition = Random.Range(-0f, 0f);
                break;
            case 3:
                randomXposition = Random.Range(-3f, 5f);
                randomYposition = Random.Range(0f, 0f);
                break;






        }
        spawnposition = new Vector3(randomXposition, randomYposition, 0f);
        newenemy = Instantiate(enemy, spawnposition, Quaternion.identity);

    }
    
}
// made by Efe