using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorController : MonoBehaviour
{
    //Used for the hub doors to load levels and require a 
    //key press to load level
    public string sceneName = "TheWoods";
    public bool keyPressed = false;
    public int requiredFloppies;

    

	private void Update()
	{
        if(Input.GetKeyDown(KeyCode.X))
        {
            PlayerController playerController = gameObject.GetComponent<PlayerController>();
            if(requiredFloppies >= playerController.floppyDiscs)
            {
                if (keyPressed)
                {
                    SceneManager.LoadScene(sceneName);
                }
            }
           
        }
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
        string objectTag = collision.gameObject.tag;



        if (objectTag == "player")
        {
            
                keyPressed = true;

        }

    }
}    
