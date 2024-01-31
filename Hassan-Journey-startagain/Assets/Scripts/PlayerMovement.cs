using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 10f;
    public bool Jump =false;

    public float horizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) { 
            horizontalMove =   Input.GetAxisRaw("Horizontal")*runSpeed;


        }

        else
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") ;


        }
        if(Input.GetKeyUp(KeyCode.Space))
        {

            Jump = true;
        }
        else
        {
            Jump = false;
        }
        controller.Move(horizontalMove, false, Jump);
    }


   

}



