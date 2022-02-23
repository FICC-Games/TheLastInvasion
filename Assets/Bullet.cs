using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer;
    
    public float direction;
    public static float bspeed;
    // Start is called before the first frame update
    void Start()
    {
        //direction = GetComponent<Gun>().direction;
        bspeed = 40;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        //skott direktion + hastigher - iram
        transform.position += new Vector3(direction*bspeed, 0, 0) * Time.deltaTime;

        if (timer == 2)
        {
            Destroy(gameObject);
        }
    }


    //den gpr s�nder p� kontakt-iram
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (true)
        {
            Destroy(gameObject);
        }
    }
}

