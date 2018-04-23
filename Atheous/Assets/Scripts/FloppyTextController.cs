using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FloppyTextController : MonoBehaviour
{

    Text floppyText;
    // Use this for initialization
    void Start()
    {

    }

    private void Awake()
    {
        floppyText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        floppyText.text = "Floppies :  " + PlayerController.floppyDiscs;

    }
}
