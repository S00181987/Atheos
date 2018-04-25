using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour {

    // Use this for initialization
    public int keys = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (PlayerController.keys >= keys)
        {
            gameObject.SetActive(false);
        }
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
    }

}

