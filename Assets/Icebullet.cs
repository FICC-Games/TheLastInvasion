using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icebullet : MonoBehaviour
{
    public GameObject iceblock;

    public static float ispeed;
    // Start is called before the first frame update
    void Start()
    {
        
        ispeed = 60;


    }

    // Update is called once per frame
    void Update()
    {

      
        //skottet �ker fram - iram
        transform.position += new Vector3(ispeed, 0, 0) * Time.deltaTime;


    }


    //spawnar ett is block d�r skottet landar och skottet f�rsvinner - iram
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(iceblock, transform.position, iceblock.transform.rotation);


        if (true)
        {
            Destroy(gameObject);
        }
    }
}

