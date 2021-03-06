using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun : MonoBehaviour
{

    float timer;

    public bool looking;

    [SerializeField]
    AudioClip lazerSFX;

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject icebullet;

    public float direction;
    float ab;
    public bool lazer;
    bool shootingice;

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
    //is skott metoden iram
    void ice() {
        timer = 0;
        Instantiate(icebullet, transform.position + new Vector3(direction * 3, ab, 0), bullet.transform.rotation);
        lazer = true;
        shootingice = false;

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
        
      

       //frys skott kod//iram
        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > 0.25f && lazer == false && shootingice == false )
        {
            shootingice = true;
            Invoke("ice", 2);
            
        }
            
        //lazer kod//iram
        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > 0.25f && lazer == true )
        {
            AudioSource.PlayClipAtPoint(lazerSFX, transform.position);
            timer = 0;
            Bullet newBullet = Instantiate(bullet, transform.position + new Vector3(direction*3, ab, 0), bullet.transform.rotation).GetComponent<Bullet>();
            newBullet.direction = direction;
        }

        //om direction = negativ, t?nk p? att skottets velocity ocks? ska bli negativ f?r att flyga ?t r?tt h?ll -iram
    }
}
