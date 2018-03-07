using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 10;
    public int health = 100, keys = 0, floppyDiscs = 0;//Number of floppies to determine what text is available to read.
    public int jumpNumber = 0;//for double jump later

    //animator variables
    private Animator animator;
    private int direction = 0, attack = 0, defence = 0, jump = 0;

    bool isOnGround = false;//for jumpie jumps.
    bool hasSword = true;//only activates when you get the sword.
    bool directionFlip = false;
    bool jumpKeyDown, grounded, canDoubleJump;
    Vector2 force;
    Vector2 velocity;
    Rigidbody2D body;
    private SpriteRenderer spriteFlip;

    private Vector3 startPosition;//change to hub or begining of level? When health = 0.


    // Use this for initialization
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

        if (health<0)
        {//choose position of respawn. Hub or checkpoint in game.
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
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

        if (Input.GetKey(KeyCode.Z) && hasSword)
        {
            attack = 1;
        }
        else if (Input.GetKeyUp(KeyCode.Z) && hasSword)
        {
            attack = 0;
        }

        if (Input.GetKey(KeyCode.UpArrow)
        {
        jumpKeyDown = true;
        }
        
        
        
        if (jumpKeyDown)
        {
            if (grounded)
            {
                rigidbody2D.velocity.y = 0;
                rigidbody2D.AddForce(new Vector2(0, jumpForce));
                canDoubleJump = true;
            }

            else
            {
                if (canDoubleJump)
                {
                    canDoubleJump = false;
                    rigidbody2D.velocity.y = 0;
                    rigidbody2D.AddForce(new Vector2(0, jumpForce));
                }
            }
        }


        animator.SetInteger("attack", attack);
        animator.SetInteger("defence", defence);
        animator.SetInteger("direction", direction);
        animator.SetInteger("jump", jump);


        if (body.velocity.y == 0)
        {
            direction = 0;
            jump = 0;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;

        //Reaper damage
        if (collision.gameObject.tag == "reaper")
        {
            health -= 20;
        }
        else if (collision.gameObject.tag == "rat")
        {
            health -= 25;
        }
        else if (collision.gameObject.tag == "bullet")
        {
            health -= 20;
        }
        else if (collision.gameObject.tag == "bat")
        {
            health -= 30;
        }

        if (tag == "ground")
        {
            grounded = true;
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

    private void OnTriggerEnter20(Collider2D collision)
    {

    }

}