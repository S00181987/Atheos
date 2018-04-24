using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatController : MonoBehaviour
{

    public int health = 75;
    public float angularSpeed = 2f, radius = 2f;
    public bool isTracking = false;
    public GameObject Player;

    private Vector2 center;
    private float rotateAngle;

	private void Start()
	{
        center = transform.position;
	}

	void Update ()
    {
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        rotateAngle += angularSpeed * Time.deltaTime;

        Vector2 offset = new Vector2(Mathf.Sin(rotateAngle), Mathf.Cos(rotateAngle)) * radius;

        transform.position = center + offset;



	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

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
