using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;
    public Transform cam;

    //speed of vertical and horizontal movement 
    public float speed = 6f;
    public float gravity;
    public float jumpPower;

    //smoothing player rotation
    public float turnSmoothTime = .1f;
    float turnSmoothVelocity;

   
    
    public GameObject groundCheck;
    public float groundDistance = .5f;
    public LayerMask groundMask;
    

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.transform.position, groundDistance, groundMask);
        //Debug.Log(isGrounded.ToString());
       
        if (isGrounded && velocity.y < 0)
        {
            velocity.y += 0f;
           // Debug.Log(isGrounded.ToString());
        }

        if(Input.GetKeyDown("space") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpPower * -2 * -gravity);
        }

        //gravity
        velocity.y += -gravity * Time.deltaTime;
        controller.Move(velocity * (Time.deltaTime));

        /*/walking 
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        */
      

    

        //direction.y += -gravity * Time.deltaTime;

        /*
        //rotations
        if (direction.magnitude >= 0.1f)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothTime, .3f);
            
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; 
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }*/
    }
}