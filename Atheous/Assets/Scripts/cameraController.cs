using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{
    public GameObject ObjToFollow;
    private Transform player;
    private Vector3 playerPosition;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("player").transform;
        playerPosition = transform.position - player.transform.position;
	}
	




	// Update is called once per frame
	void Update ()
    {

        playerPosition = player.position;
        playerPosition.z = transform.position.z;
        transform.position = playerPosition;
	}
}
