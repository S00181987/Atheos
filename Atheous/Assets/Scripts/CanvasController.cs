using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {

    public GameObject c1, floppyOne, floppyTwo, floppyThree, floppyFour, arrowOne, arrowTwo, arrowThree, arrowFour;
    public GameObject key1, key2, key3, key4, key5;
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
        arrowOne.gameObject.SetActive(false);
        arrowTwo.gameObject.SetActive(false);
        arrowThree.gameObject.SetActive(false);
        arrowFour.gameObject.SetActive(false);
        key1.gameObject.SetActive(false);
        key2.gameObject.SetActive(false);
        key3.gameObject.SetActive(false);
        key4.gameObject.SetActive(false);
        key5.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
    {
        elapsedTime += Time.deltaTime;

        if (PlayerController.floppyDiscs == 0)
        {
            c1.gameObject.SetActive(true);
            arrowOne.gameObject.SetActive(true);
            //Turns off other arrows
            arrowTwo.gameObject.SetActive(false);
            arrowThree.gameObject.SetActive(false);
            arrowFour.gameObject.SetActive(false);
            if(elapsedTime >= screenTime)
            {
                c1.gameObject.SetActive(false);
            }
        }
        else if (PlayerController.floppyDiscs == 1)
        {
            floppyOne.gameObject.SetActive(true);
            arrowTwo.gameObject.SetActive(true);

            arrowOne.gameObject.SetActive(false);
            arrowThree.gameObject.SetActive(false);
            arrowFour.gameObject.SetActive(false);
            if (elapsedTime >= screenTime)
            {
                floppyOne.gameObject.SetActive(false);
            }
        }
        else if(PlayerController.floppyDiscs == 2)
        {
            floppyTwo.gameObject.SetActive(true);
            arrowThree.gameObject.SetActive(true);

            arrowOne.gameObject.SetActive(false);
            arrowTwo.gameObject.SetActive(false);
            arrowFour.gameObject.SetActive(false);
            if (elapsedTime >= screenTime)
            {
                floppyTwo.gameObject.SetActive(false);
            }
        }
        else if (PlayerController.floppyDiscs == 3)
        {
            floppyThree.gameObject.SetActive(true);
            arrowFour.gameObject.SetActive(true);

            arrowOne.gameObject.SetActive(false);
            arrowTwo.gameObject.SetActive(false);
            arrowThree.gameObject.SetActive(false);
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

        //KEYS * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        if(PlayerController.keys ==1)
        {
            key1.gameObject.SetActive(true);
        }
        else if (PlayerController.keys == 2)
        {
            key2.gameObject.SetActive(true);
        }
        else if (PlayerController.keys == 3)
        {
            key3.gameObject.SetActive(true);
        }
        else if (PlayerController.keys == 4)
        {
            key4.gameObject.SetActive(true);
        }
        else if(PlayerController.keys == 5)
        {
            key5.gameObject.SetActive(true);
        }

		
	}
}
