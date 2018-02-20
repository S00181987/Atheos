using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    //need to add bullet to in-game obects
    //public GameObject bullet;
    public int health = 60;
    public float spawnTime = 2;
    public float elapsedTime = 0;
    
	// Update is called once per frame
	void Update ()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= spawnTime)
        {
            //Same object to be added here:
            //GameObject newBullet = Instantiate(bullet);
            //newBullet.transform.position = transform.position;
            elapsedTime = 0;
        }

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
            health -= 25;
        }
    }

}
