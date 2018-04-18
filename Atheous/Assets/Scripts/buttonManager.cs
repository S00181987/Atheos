using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NewGameBtn(string TheHub)
    {
        SceneManager.LoadScene("TheHub");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
