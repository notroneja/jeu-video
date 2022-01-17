using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
// mouvement
    public CharacterController controller;
//gravit�
    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;
 // ground check pour reset la v�locit�
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    // saut
    public float JumpHigh = 3f;

    // Update is called once per frame
    //jamais oublier le time delta time sinon �a va finir comme fallout 76 et les joueurs avec une meilleur frame rate vont aller plus vite que les autres
    void Update()
    {
        //reset v�lo
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        // mouvement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); 
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        //gravit�
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
        // saut
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHigh * -2f * gravity);
        }
    }
}
