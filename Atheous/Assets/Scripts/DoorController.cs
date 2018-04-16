using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorController : MonoBehaviour
{


    //Used for the hub doors to load levels and require a 
    //key press to load level
    public string sceneName = "TheWoods";


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string objectTag = collision.gameObject.tag;

        if (objectTag == "Player" && Input.GetKeyDown(KeyCode.X))
        {
            if (!string.IsNullOrEmpty(sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}    
