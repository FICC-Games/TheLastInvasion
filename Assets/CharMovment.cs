using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovment : MonoBehaviour
{
    [SerializeField]
    Vector3 direction = new Vector3(1, 0, 0);
    [SerializeField, Range(1, 20)]
    float speed;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode jump;
    [SerializeField]
    KeyCode crouch;
    private Rigidbody2D rb;
    bool isonground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(crouch))
        {
            transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;   
            rb.velocity = Vector2.up * jumpVelocity;
            isonground = false;
        }
    }
}
