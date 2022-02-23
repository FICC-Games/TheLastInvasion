using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tim.B
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
        
    }
    private void Awake()
    {
        rb2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            // Om du trycker ner höger knappen (I det här fallet "D") så kommer du gå åt höger och starta en animation på gubben. Playern kommer också riktas åt det hållet du går.
            if (Input.GetKey(right))
            {
                animator.SetBool("isRunning", true);
                transform.position += new Vector3(speed / Crouchspeed, 0, 0) * Time.deltaTime;
                Looking = true;
                Player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            // Om du trycker ner vänster knappen (I det här fallet "A") så kommer du gå åt Vänster och starta en animation på gubben. Playern kommer också riktas åt det hållet du går.
            else if (Input.GetKey(left))
            {
                animator.SetBool("isRunning", true);
                transform.position -= new Vector3(speed / Crouchspeed, 0, 0) * Time.deltaTime;
                Looking = false;
                Player.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
            // Ser till att Gubben slutar med Animationen när du slutat gå åt något håll vilket startar en idle Animation på gubben.
            else
            {
                animator.SetBool("isRunning", false);
            };
            // När du trycker ner i det här fallet "Space" hoppar gubben om den är på marken,
            // Det finns också en eller i mitten av if koden för att man ska kunna trycka på "W" för att hoppa också,
            // Jag tycker det är jobbigt när man inte kan använda båda knapparna för att hoppa.
            //Koden under if satsen gör att gubben hoppar en viss höjd och sätter så att gubben inte längre är på marken.
            //för att få till baka "onground" så måste spelare komma i kontakt med något som har tagen "Ground"
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
        //Tar Bort Jumping Animationen och sätter "onground" True vilket gör att man kan trycka på en av "Jump" knapparna för att hoppa.
        if (collision.gameObject.tag == "Ground")
        {
            onground = true;
            animator.SetBool("isJumping", false);
        }
    }
}
//Made by Tim.B