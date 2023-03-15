using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : StateMachineBehaviour
{
    GameController gameController;
    private float timer;
    private float check = 1;
    private Animation anim;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("attack");
        anim = animator.GetComponent<Animation>();
        anim.Play("attack_short_001");
        gameController = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameController>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {


            timer += Time.deltaTime;
           
            if (timer > 0.5f && timer < 1.0f)
            {
                if(gameController.canPlayerBeHit == true)
                {
                    if(check == 1)
                    {
                        gameController.bossStrike();
                        check -= 1;
                    }
                        
                }
            }    


            if (timer > 1.5f)
            {
                animator.SetTrigger("attackOver");
                Debug.Log("attack over");
            }

            
        
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        anim.Play("idle_normal");
        timer = 0.0f;
        check = 1;
        animator.ResetTrigger("attackOver");
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
