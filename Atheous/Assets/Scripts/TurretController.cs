using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{

    //private Animator attack;
    public GameObject bulletHor;
    public int health = 60;
    public float spawnTimeHor = 2;
    public float elapsedTimeHor = 0;

    private void Start()
    {
        //attack = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
    {
        elapsedTimeHor += Time.deltaTime;

        if (elapsedTimeHor >= spawnTimeHor)
        {
            GameObject newBullet = Instantiate(bulletHor);
            newBullet.transform.position = transform.position;
            elapsedTimeHor = 0;
        }

    }


}
