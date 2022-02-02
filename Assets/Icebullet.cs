using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icebullet : MonoBehaviour
{
    bool lazer;

    float timer;
    
    public GameObject iceblock;

    public static float ispeed;
    // Start is called before the first frame update
    void Start()
    {
        
        ispeed = 5;
        lazer = GetComponent<Gun>();


    }

    // Update is called once per frame
    void Update()
    {

      

        transform.position += new Vector3(ispeed, 0, 0) * Time.deltaTime;


    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(iceblock, transform.position, iceblock.transform.rotation);


        if (true)
        {
            Destroy(gameObject);
        }
    }
}

