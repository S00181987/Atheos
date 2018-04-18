using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{
    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	

    void FindPLayer()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }


	// Update is called once per frame
	void Update ()
    {
        if(player == null)
        {
            FindPLayer();
        }
        offset.x = player.transform.position.x;
        offset.y = player.transform.position.y;
        offset.z = transform.position.z;

        transform.position = offset;
	}
}
