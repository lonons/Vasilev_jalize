using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_animator_controller : MonoBehaviour
{
    Animator animator;
    bool isRunning;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalk", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isRun", true);
                animator.SetBool("isWalk", false);
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
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isBack", true);
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
