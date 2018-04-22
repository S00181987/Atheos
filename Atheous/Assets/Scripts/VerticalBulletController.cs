using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBulletController : MonoBehaviour {

    //fast enough?
    public float speed = -10;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "player" || collision.gameObject.tag == "wall" || collision.gameObject.tag == "rat")
        {
            Destroy(gameObject);
        }
    }
}
