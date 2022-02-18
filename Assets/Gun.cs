using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun : MonoBehaviour
{

    float timer;

    public bool looking;



    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject icebullet;

    public float direction;
    float ab;
    public bool lazer;

    Movment move;
    
    public object Yield
    {
        get; private set;
    }

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Movment>();
        lazer = true;
    }
    void ice() {
        timer = 0;
        Instantiate(icebullet, transform.position + new Vector3(direction * 3, ab, 0), bullet.transform.rotation);

        lazer = true;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
            
        if (move.Looking == true)
        {
            direction = 1.5f;
        }
        if (move.Looking == false)
        {
            direction = -1.5f;
        }
        
      

       //frys skott kod//
        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > 0.25f && lazer == false )
        {
            Invoke("ice", 2);
            
        }
            
        //lazer kod//
        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > 0.25f && lazer == true )
        {
            timer = 0;
            Bullet newBullet = Instantiate(bullet, transform.position + new Vector3(direction*3, ab, 0), bullet.transform.rotation).GetComponent<Bullet>();
            //newBullet.direction = direction;
        }

        //om direction = negativ, tänk på att skottets velocity också ska bli negativ för att flyga åt rätt håll -Simon
    }
}
