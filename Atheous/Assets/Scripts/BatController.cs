using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatController : MonoBehaviour
{

    public int health = 75;
    public float speed = 2;
    public float trackRadius = 5f;
    public bool isTracking = false;
    public GameObject Player;

	void Update ()
    {
        //Vector3 localPosition 
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if (Vector2.Distance(transform.position, Player.transform.position) <= trackRadius)
        {
            isTracking = true;
        }
        else
        {
            isTracking = false;
        }



	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //string tag = collision.gameObject.tag;


    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "player")
        {
            if (GameObject.Find("player").GetComponent<PlayerController>().isAttacking)
            {
                health -= 25;
            }

        }		
	}
}
