using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyTextController : MonoBehaviour
{

    Text keyText;

    // Use this for initialization
    void Start()
    {

    }

    private void Awake()
    {
        keyText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys :  " + PlayerController.keys;

    }
}
