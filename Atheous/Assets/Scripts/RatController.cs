using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatController : MonoBehaviour
{
    //speed to be changed if nessesary
    public float directionHor = 1, speedHor = 2;
    public int health = 50;
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(directionHor * speedHor, 0);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            directionHor *= -1;
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
