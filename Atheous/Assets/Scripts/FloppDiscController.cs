﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FloppDiscController : MonoBehaviour 
{
    
    public int floppies;



	// Use this for initialization
	void Start () 
    {
        
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