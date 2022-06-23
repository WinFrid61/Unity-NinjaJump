using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController2D : MonoBehaviour
{
    float horizontal;
    public Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    public static PlayerController2D instance;
    bool isGrounded;

    [SerializeField]
    Transform groundCheck;
    [SerializeField]
    Transform groundCheckL;
    [SerializeField]
    private Transform groundCheckR;

    [SerializeField]
    private float runSpeed = 6.5f;
    //[SerializeField]
    //float jumpSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (instance == null)
        {
            instance = this;
        }
    }

    private void GroundMovement()
    {
        if (transform.position.x > 0.3f)
        {
            transform.position = new Vector3(-10.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -10.3f)
        {
            transform.position = new Vector3(0.3f, transform.position.y, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "EndGameZone")
        {
            SceneManager.LoadScene("EndGame");
        }
    }

    private void FixedUpdate()
    {
        GroundMovement();
            horizontal = Input.acceleration.x;

            if (Input.acceleration.x > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (Input.acceleration.x < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                
            }
            rb2d.velocity = new Vector2(Input.acceleration.x * 20f, rb2d.velocity.y);

            if (Input.GetKey("d") || Input.GetKey("right"))
            {
                rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
                spriteRenderer.flipX = false;
            }
            else if (Input.GetKey("a") || Input.GetKey("left"))
            {
                rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
                spriteRenderer.flipX = true;
            }
            //else
            //{
            //    if (isGrounded)
            //        rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            //}
        //Движение по клавиатуре. Игра под Android, поэтому уже не используется, но оставил, может, когда-нибудь переделаю

        //    if ((Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"))) ||
        //        (Physics2D.Linecast(transform.position, groundCheckL.position, 1 << LayerMask.NameToLayer("Ground"))) ||
        //        (Physics2D.Linecast(transform.position, groundCheckR.position, 1 << LayerMask.NameToLayer("Ground"))))
        //    {
        //        isGrounded = true;
        //    }

        //    else
        //    {
        //        isGrounded = false;
        //    }

        //    if (Input.GetKey("d") || Input.GetKey("right"))
        //    {
        //        rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
        //        spriteRenderer.flipX = false;
        //    }
        //    else if (Input.GetKey("a") || Input.GetKey("left"))
        //    {
        //        rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
        //        spriteRenderer.flipX = true;

        //    }
        //    else
        //    {
        //        if (isGrounded)
        //            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        //    }

        //    if (Input.GetKey("w") || Input.GetKey("up") || Input.GetKey("space"))
        //    {
        //        if (isGrounded)
        //            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        //    }
    }
}