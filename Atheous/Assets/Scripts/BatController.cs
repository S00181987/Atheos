using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatController : MonoBehaviour
{

    //Need the player object for code to work
    public int health = 75;
    public float speed = 2;
    //public GameObject Player;

	void Update ()
    {
        //Vector3 localPosition 
        if (health <= 0)
        {
            Destroy(gameObject);
        }
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;

        if (tag == "sword")
        {
            //verify numbers with group
            health -= 25;
        }
    }
}
