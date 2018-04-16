using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTrigger : MonoBehaviour
{

    public string sceneName = "TheHub";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string objectTag = collision.gameObject.tag;

        if (objectTag == "Player")
        {
            if (!string.IsNullOrEmpty(sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
