using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Player_animator_controller : MonoBehaviour
{
    Animator animator;
    AudioSource soundStep;
    bool isRunning;
    void Awake()
    {
        animator = GetComponent<Animator>();
        soundStep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalk", true);
            soundStep.pitch = 0.75f;
            if (!soundStep.isPlaying)
            {
                soundStep.Play();
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isRun", true);
                animator.SetBool("isWalk", false);
                soundStep.pitch = 0.85f;
            }
            else
            {
                animator.SetBool("isRun", false);
                animator.SetBool("isWalk", true);
            }

        }
        else
        {
            animator.SetBool("isRun", false);
            animator.SetBool("isWalk", false);
            if (soundStep.isPlaying)
            {
                soundStep.Stop();
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isBack", true);
            soundStep.pitch = 0.75f;
        }
        else animator.SetBool("isBack", false);

        //if (Input.GetKey(KeyCode.A))
        //{
        //    animator.SetBool("isLeftStrafe", true);
        //    animator.SetBool("isRightStrafe", false);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    animator.SetBool("isRightStrafe", true);
        //    animator.SetBool("isLeftStrafe", false);
        //}
    }
}
