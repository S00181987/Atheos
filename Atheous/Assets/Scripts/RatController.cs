using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatController : MonoBehaviour
{
    //speed to be changed if nessesary
    public float directionHor = 1, speedHor = 2;
    public int health = 50;
    private SpriteRenderer ratFlip;
    int ratDirectionFlip = 1;


	private void Start()
	{
        ratFlip = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update ()
    {


        GetComponent<Rigidbody2D>().velocity = new Vector2(directionHor * speedHor, 0);
        if (health <= 0)
        {
            Destroy(gameObject);
        }



        if (ratDirectionFlip%2 != 0)
        {
            ratFlip.flipX = true;
        }
        else
        {
            ratFlip.flipX = false;
        }

        if (ratDirectionFlip > 2)
        {
            ratDirectionFlip = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "wall")
        {
            directionHor *= -1;
            ratDirectionFlip += 1;
        }

        string tag = collision.gameObject.tag;

        if (tag == "player")
        {
            if (GameObject.Find("player").GetComponent<PlayerController>().isAttacking)
            {
                health -= 25;
            }
        }

	}

}
