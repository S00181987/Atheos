using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;
    private int direction = 0;
    private int attack = 0;
    private int defence = 0;
    private int jump = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        direction = 0;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            direction = 1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            attack = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            defence = 1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            jump = 1;
        }

        
    }
}
