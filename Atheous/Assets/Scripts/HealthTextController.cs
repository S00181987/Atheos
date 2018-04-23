using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthTextController : MonoBehaviour {

    Text healthText;
	// Use this for initialization
	void Start () 
    {
        
	}

	private void Awake()
	{
        healthText = GetComponent<Text>();
	}
	// Update is called once per frame
	void Update () 
    {
        healthText.text = "Health :  " + PlayerController.health;
		
	}
}
