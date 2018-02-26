using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalTurretController : MonoBehaviour
{

    public GameObject bulletVert;
    public float spawnTimeVert = 2;
    public float elapsedTimeVert = 0;

    // Update is called once per frame
    void Update()
    {
        elapsedTimeVert += Time.deltaTime;

        if (elapsedTimeVert >= spawnTimeVert)
        {
            GameObject newBullet = Instantiate(bulletVert);
            newBullet.transform.position = transform.position;
            elapsedTimeVert = 0;
        }



    }


}
