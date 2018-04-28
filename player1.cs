using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class player1 : MonoBehaviour {


    private CharacterController controller;
    private float speed = 5.0f;
    public bool isGrounded;
    public Vector3 moveVector;
    public float verticalVelocity;
    public float jumpSpeed = 40.0f;
    public float gravity = 5.0f;
    private bool grounded = false;
    private bool canJump;
    Rigidbody rb;
    Animator anim;
    public int forceConst = 50;
    // Use this for initialization
    void Start()
    {

        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        isGrounded = true;
    }
    // Update is called once per frame

   void movementControl(string state)
    {
        switch (state)
        {
            case "WalkingForward":
                anim.SetBool("isWalkingForward", true);
                anim.SetBool("isWalkingBackward", false);
                anim.SetBool("isIdle", false);
                break;
            case "WalkingBackward":
                anim.SetBool("isWalkingForward", false);
                anim.SetBool("isWalkingBackward", true);
                anim.SetBool("isIdle", false);
                break;
            case "idle":
                anim.SetBool("isWalkingForward", false);
                anim.SetBool("isWalkingBackward", false);
                anim.SetBool("isIdle", true);
                break;
        }
    }
    void Update()
    {
        // controller.Move(Vector3.forward * Time.deltaTime * speed);
        moveVector = Vector3.zero;
        /*if (controller.isGrounded) nasser 
        {
            verticalVelocity = 0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }*/

        //Y is up and down
        //moveVector.y = verticalVelocity;
        /* if (controller.isGrounded) nasser
         {
             if (Input.GetButton("Jump"))
                 moveVector.y = jumpSpeed ;
         }*/
        //X is left and right
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            moveVector.z = Input.GetAxisRaw("Vertical") * speed;
            movementControl("WalkingForward");
            isGrounded = true;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            moveVector.z = Input.GetAxisRaw("Vertical") * speed;
            movementControl("WalkingBackward");
            isGrounded = true;
        }
        // Apply gravity
        // else if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        else if (Input.GetButton("Jump"))
        {
            anim.SetTrigger("isJumping");
            rb.AddForce(0, jumpSpeed * Time.deltaTime, 0);
            
             moveVector.y = jumpSpeed * Time.deltaTime;
             moveVector.y=0f;
           //moveVector.y -= gravity * Time.deltaTime;
           isGrounded = false;
        }
        ///moveVector.y -= gravity * Time.deltaTime;   nasser
        //Z is forward and backward
        else if (Input.GetAxisRaw("Horizontal") != 0)
        {
            moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
            isGrounded = true;
        }
        else
        {
            movementControl("idle");
            moveVector.y = 0;
            isGrounded = true;
        }
        controller.Move(moveVector * Time.deltaTime);



    }


}


