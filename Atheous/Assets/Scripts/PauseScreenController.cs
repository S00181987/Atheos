using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenController : MonoBehaviour 
{

    public GameObject pauseMenu;

	private void Start()
	{
        pauseMenu.SetActive(false);
	}

	// Update is called once per frame
	void Update () 
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Exit()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void Unpause()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
