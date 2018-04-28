using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour {

    private CharacterController controller;
    private float speed = 5.0f;
    public Vector3 moveVector;
    public float verticalVelocity;
    public float jumpSpeed = 18.0f;
    public float gravity= 10.0f;
     private bool grounded = false;
     private bool canJump;
     //private RigidBody selfRigidbody;
     public int forceConst = 50;
    // Use this for initialization
    void Start()
    {

        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    
    void Update()
    {
       // controller.Move(Vector3.forward * Time.deltaTime * speed);
        moveVector = Vector3.zero;
        if (controller.isGrounded)
        {
            verticalVelocity = 0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        //X is left and right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        //Y is up and down
        //moveVector.y = verticalVelocity;
        if (controller.isGrounded)
        {
            if (Input.GetButton("Jump"))
                moveVector.y = jumpSpeed * 3 ;
        }
        // Apply gravity
        moveVector.y -= gravity * Time.deltaTime;
        //Z is forward and backward
        moveVector.z = Input.GetAxisRaw("Vertical") * speed; ;
        //
        controller.Move(moveVector * Time.deltaTime);
        
        

    }

   
}
