using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
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
