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
            // Om du trycker ner h�ger knappen (I det h�r fallet "D") s� kommer du g� �t h�ger och starta en animation p� gubben. Playern kommer ocks� riktas �t det h�llet du g�r.
            if (Input.GetKey(right))
            {
                animator.SetBool("isRunning", true);
                transform.position += new Vector3(speed / Crouchspeed, 0, 0) * Time.deltaTime;
                Looking = true;
                Player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            // Om du trycker ner v�nster knappen (I det h�r fallet "A") s� kommer du g� �t V�nster och starta en animation p� gubben. Playern kommer ocks� riktas �t det h�llet du g�r.
            else if (Input.GetKey(left))
            {
                animator.SetBool("isRunning", true);
                transform.position -= new Vector3(speed / Crouchspeed, 0, 0) * Time.deltaTime;
                Looking = false;
                Player.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
            // Ser till att Gubben slutar med Animationen n�r du slutat g� �t n�got h�ll vilket startar en idle Animation p� gubben.
            else
            {
                animator.SetBool("isRunning", false);
            };
            // N�r du trycker ner i det h�r fallet "Space" hoppar gubben om den �r p� marken,
            // Det finns ocks� en eller i mitten av if koden f�r att man ska kunna trycka p� "W" f�r att hoppa ocks�,
            // Jag tycker det �r jobbigt n�r man inte kan anv�nda b�da knapparna f�r att hoppa.
            //Koden under if satsen g�r att gubben hoppar en viss h�jd och s�tter s� att gubben inte l�ngre �r p� marken.
            //f�r att f� till baka "onground" s� m�ste spelare komma i kontakt med n�got som har tagen "Ground"
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
        //Tar Bort Jumping Animationen och s�tter "onground" True vilket g�r att man kan trycka p� en av "Jump" knapparna f�r att hoppa.
        if (collision.gameObject.tag == "Ground")
        {
            onground = true;
            animator.SetBool("isJumping", false);
        }
    }
}
//Made by Tim.B