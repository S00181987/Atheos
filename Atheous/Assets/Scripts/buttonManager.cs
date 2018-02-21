using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public void NewGameBtn(string main)
    {
        SceneManager.LoadScene(main);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
