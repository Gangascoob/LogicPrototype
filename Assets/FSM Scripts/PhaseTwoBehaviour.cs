using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseTwoBehaviour : StateMachineBehaviour
{

    private Transform playerPos;
    public float speed = 1.0f;
    public float distance;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Phase Two");
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var step = speed * Time.deltaTime;

        Vector3 targetDirection = playerPos.position - animator.transform.position;


        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        animator.transform.position = Vector3.MoveTowards(animator.transform.position, playerPos.position, speed * Time.deltaTime);
        distance = Vector3.Distance(animator.transform.position, playerPos.position);

        animator.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(animator.transform.forward, targetDirection, step, 0.0f));

        if (distance < 2.5f)
        {
            animator.SetTrigger("closeDistance");
            
        }

        Debug.Log("distance is:" + distance);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
