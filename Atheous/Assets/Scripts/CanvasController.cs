using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {

    public GameObject c1, floppyOne, floppyTwo, floppyThree, floppyFour;
    public float elapsedTime = 0.0f, screenTime = 10.0f;
	// Use this for initialization
	void Start () 
    {
        elapsedTime = 0;
        c1.gameObject.SetActive(false);
        floppyOne.gameObject.SetActive(false);
        floppyTwo.gameObject.SetActive(false);
        floppyThree.gameObject.SetActive(false);
        floppyFour.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
    {
        elapsedTime += Time.deltaTime;

        if (PlayerController.floppyDiscs == 0)
        {
            c1.gameObject.SetActive(true);
            if(elapsedTime >= screenTime)
            {
                c1.gameObject.SetActive(false);
            }
        }
        else if (PlayerController.floppyDiscs == 1)
        {
            floppyOne.gameObject.SetActive(true);
            if (elapsedTime >= screenTime)
            {
                floppyOne.gameObject.SetActive(false);
            }
        }
        else if(PlayerController.floppyDiscs == 2)
        {
            floppyTwo.gameObject.SetActive(true);
            if (elapsedTime >= screenTime)
            {
                floppyTwo.gameObject.SetActive(false);
            }
        }
        else if (PlayerController.floppyDiscs == 3)
        {
            floppyThree.gameObject.SetActive(true);
            if (elapsedTime >= screenTime)
            {
                floppyThree.gameObject.SetActive(false);
            }
        }
        else if (PlayerController.floppyDiscs == 4)
        {
            floppyFour.gameObject.SetActive(true);
            if (elapsedTime >= screenTime)
            {
                floppyFour.gameObject.SetActive(false);
            }
        }
		
	}
}
