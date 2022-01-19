using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour // pour plus d'information a propos de ce script contactez jée :)
{
    Animator animator;
    //int isWalkingHash;
   // int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //isWalkingHash = animator.StringToHash("isWalking");
        //isRunningHash = animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        // l'animation de marche 
        //bool isWalking = animator.GetBool(isWalkingHash);
        bool fowardpress = Input.GetKey("w"); // search finder : input w foward avancer
        if (fowardpress)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        //l'animation de course 
        //bool isRunning = animator.GetBool(isRunningHash);
        bool shiftpress = Input.GetKey(KeyCode.LeftShift); //search finder : input shift 
        if (shiftpress)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }


        //l'animation de s'acroupire
        bool Ctrlpress = Input.GetKey(KeyCode.LeftControl); //search finder : input control ctrl
        if (Ctrlpress)
        {
            animator.SetBool("isCroutching", true);
            animator.SetBool("isRunning", false);
        }
        else
        {
            animator.SetBool("isCroutching", false);
        }
    }
}
