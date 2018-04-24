using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 2f;
    public static int health = 100, keys = 0, floppyDiscs = 0;//Number of floppies to determine what text is available to read.
    public int jumpNumber = 2, maxJumps = 2;

    //animator variables
    private Animator animator;
    private int direction = 0, attack = 0, defence = 0, jump = 0;

    bool isOnGround = false;
    bool hasSword = true;//only activates when you get the sword.
    bool directionFlip = false;
    bool jumpKeyDown, grounded, canDoubleJump = true;
    public bool isAttacking = false;
    Vector2 force;
    Vector2 velocity;
    Rigidbody2D body;
    private SpriteRenderer spriteFlip;
    private Vector3 startPosition;//change to hub or begining of level? When health = 0.



    void Start ()
    {
        force.y = jumpForce;
        body = GetComponent<Rigidbody2D>();
        startPosition = transform.position;//amend for Hub position?	
        animator = GetComponent<Animator>();
        spriteFlip = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        isAttacking = false;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        velocity.x = x * speed;
        velocity.y = y * speed;

        if (directionFlip)
        {
            spriteFlip.flipX = true;
        }
        else
        {
            spriteFlip.flipX = false;
        }

        if (health<=0)
        {//choose position of respawn. Hub or checkpoint in game.
            SceneManager.LoadScene("TheHub");
            health = 100;
        }

        //movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            body.velocity = new Vector2(x * speed, body.velocity.y);
            direction = 1;
            directionFlip = false;

            if(Input.GetKey(KeyCode.Z))
            {
                attack = 1;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.velocity = new Vector2(x * speed, body.velocity.y);
            direction = 1;
            directionFlip = true;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            body.velocity = new Vector2(0,0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            body.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.C))
        {
            defence = 1;
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            defence = 0;
        }
        //SWORD * * * * * * * * * * * * * * * * * * * * * * * *
        //Sword obtained after level one
        /*
        if(floppyDiscs >= 1)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                attack = 1;
                isAttacking = true;
            }
            else if (Input.GetKeyUp(KeyCode.Z))
            {
                attack = 0;
            }
        }
        */

        if (Input.GetKey(KeyCode.Z) && hasSword)
        {
            attack = 1;
            isAttacking = true;
        }
        else if (Input.GetKeyUp(KeyCode.Z) && hasSword)
        {
            attack = 0;
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            jumpKeyDown = true;
        }



        //JUMPS * * * * * * * * * * * * * * * * * * * * * * * *
        /*
        if (floppyDiscs >= 2)
            //double jump obtained after level 2
            maxJumps = 2;
        else
            maxJumps = 1;
        */

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //DoubleJumpTwo();
            doubleJump();
            jump = 1;
        }


        animator.SetInteger("attack", attack);
        animator.SetInteger("defence", defence);
        animator.SetInteger("direction", direction);
        animator.SetInteger("jump", jump);


        if (body.velocity.y == 0.0)
        {
            direction = 0;
            jump = 0;
        }

    }




    private void doubleJump()
    {
        if(jumpNumber >0)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumpNumber -= 1;
            isOnGround = false;
        }
        else if(jumpNumber == 0)
        {
            return;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;

        //Reaper damage


        if (collision.gameObject.tag == "bullet")
        {
            if(!isAttacking)
            {
                health -= 20;
            }

        }
        if (collision.gameObject.tag == "rat")
        {
            if (!isAttacking)
            {
                health -= 25;
            }

        }

        if (tag == "ground" || tag == "wall")
        {
            grounded = true;
            jumpNumber = maxJumps;
        }

        if (collision.gameObject.tag == "floppy")
        {
            floppyDiscs++;
        }
        else if (collision.gameObject.tag == "key")
        {
            keys++;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "reaper")
        {
            if (!isAttacking)
            {
                health -= 20;
            }

        }
        else if (collision.gameObject.tag == "bat")
        {
            if (!isAttacking)
            {
                health -= 30;
            }

        }
    }

}