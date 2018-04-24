using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenController : MonoBehaviour 
{

    public GameObject pauseMenu;

	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKey(KeyCode.M))
        {
            Pause();
        }
		
	}

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    void Exit()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void Unpause()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
