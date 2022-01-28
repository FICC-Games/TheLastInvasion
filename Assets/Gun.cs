using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun : MonoBehaviour
{

    float timer;

    public bool Looking;



    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject icebullet;

    public float direction;
    float ab;
    public bool lazer;
    public object Yield
    {
        get; private set;
    }

    // Start is called before the first frame update
    void Start()
    {
        Looking = true;
        lazer = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
            
        if (Looking == true)
        {
            Direction = 1.5f;
        }
        if (Looking == false)
        {
            Direction -= 1.5f;
        }
        
      

       //frys skott kod//
        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > 0.25f && lazer == false )
        {
            timer = 0;
            Instantiate(icebullet, transform.position + new Vector3(Direction, ab, 0), bullet.transform.rotation);

            lazer = true;
        }
            
        //lazer kod//
        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > 0.25f && lazer == true )
        {
            timer = 0;
            Instantiate(bullet, transform.position + new Vector3(Direction, ab, 0), bullet.transform.rotation);
        }

        
    }
}
