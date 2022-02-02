using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{

    [SerializeField, Range(10, 100)]
    float speed;
    [SerializeField, Range(5, 50)]
    float JumpHight;
    [SerializeField]
    KeyCode jump;
    [SerializeField]
    KeyCode jumpx2;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode Crouch;
    private int Crouchspeed;
    private Rigidbody2D rb2d;
    bool onground;
    public GameObject Player;
    public Animator animator;

    public bool Looking;
    //if Looking = true; The Character is looking right
    //if Looking = false; The Character is looking left

    // Start is called before the first frame update
    void Start()
    {
        onground = true;
    }
    private void Awake()
    {
        rb2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        {

            if (Input.GetKey(right))
            {
                animator.SetBool("isRunning", true);
                transform.position += new Vector3(speed / Crouchspeed, 0, 0) * Time.deltaTime;
                Looking = true;
                Player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            else if (Input.GetKey(left))
            {
                animator.SetBool("isRunning", true);
                transform.position -= new Vector3(speed / Crouchspeed, 0, 0) * Time.deltaTime;
                Looking = false;
                Player.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
            else
            {
                animator.SetBool("isRunning", false);
            };
            if ((Input.GetKeyDown(jump) && onground) || (Input.GetKeyDown(jumpx2) && onground))
            {
                float jumpVelocity = JumpHight;
                rb2d.velocity = Vector2.up * jumpVelocity;
                onground = false;
                animator.SetBool("isJumping", true);
            }
        }

        {
            if (Input.GetKey(Crouch))
            {
                Crouchspeed = 2;
            }
            else
            {
                Crouchspeed = 1;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onground = true;
            animator.SetBool("isJumping", false);
        }
    }
}
//Made by Tim.B