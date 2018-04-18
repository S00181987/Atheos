using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD

public class FloppDiscController : MonoBehaviour {
=======
public class FloppDiscController : MonoBehaviour 
{
    PlayerController playerController;
    public int floppies;

>>>>>>> b673542706a0de4b292c24ff67b41b7c24c51f91

	// Use this for initialization
	void Start () 
    {
        playerController = GameObject.FindGameObjectWithTag("player").GetComponent<PlayerController>();
        if(PlayerController.floppyDiscs >= floppies)
        {
            gameObject.SetActive(false);
        }

		
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}