using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f;
    Vector3 moveDirection = Vector3.zero; //X = 0, Y = 0, Z = 0​
    float gravity = 7f;
    CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

  
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * Time.deltaTime);

        //if (controller.isGrounded)​

        //{​

        //    if (Input.GetKey(KeyCode.W))​

        //    {​

        //        //walk forward​

        //        moveDirection = new Vector3(0, 0, 1); //move along z axis only​

        //        moveDirection *= speed; //move at a speed​

        //    }​

        //}​
        /*if (controller.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }*/
    }
}
