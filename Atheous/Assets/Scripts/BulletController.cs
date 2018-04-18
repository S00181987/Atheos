using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    //fast enough?
    public float speed = 10f;
    public float trackRadius = 5f;
    private bool isTracking = false;
    public GameObject TrackingObject;


	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
		if (collision.gameObject.tag == "player") 
		{
			Destroy (gameObject);
		}

    }
}
