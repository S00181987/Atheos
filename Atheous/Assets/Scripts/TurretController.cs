using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    
    public GameObject bullet;
    public int health = 60;
    public float spawnTime = 2;
    public float elapsedTime = 0;
    
	// Update is called once per frame
	void Update ()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= spawnTime)
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = transform.position;
            elapsedTime = 0;
        }



    }


}
