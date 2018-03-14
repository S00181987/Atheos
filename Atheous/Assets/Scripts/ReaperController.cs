using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaperController : MonoBehaviour
{
    //speed can be changed at a later date

    public float directionVert = 1, speedVert = 2;
    public int health = 25;
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speedVert * directionVert);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Using tags to change direction
        if (collision.gameObject.tag == "ground")
        {
            directionVert *= -1;
        }

        string tag = collision.gameObject.tag;

        if (tag == "player")
        {
            if(GameObject.Find("player").GetComponent<PlayerController>().isAttacking)
            {
                health -= 25;
            }

        }
    }
}
