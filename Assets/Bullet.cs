using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer;
    bool lazer;
    public float direction;

    public static float bspeed;
    // Start is called before the first frame update
    void Start()
    {
        //direction = GetComponent<Gun>().direction;
        bspeed = 40;
    }

    // Update is called once per frame
    void Update()
    {
       
        
            transform.position += new Vector3(direction*bspeed, 0, 0) * Time.deltaTime;

        



    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (true)
        {
            Destroy(gameObject);
        }
    }
}
