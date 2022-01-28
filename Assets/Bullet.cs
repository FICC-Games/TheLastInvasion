using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer;
    bool lazer;
    

    public static float bspeed;
    // Start is called before the first frame update
    void Start()
    {
        
            bspeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
       
        
            transform.position += new Vector3(bspeed, 0, 0) * Time.deltaTime;

        



    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (true)
        {
            Destroy(gameObject);
        }
    }
}

