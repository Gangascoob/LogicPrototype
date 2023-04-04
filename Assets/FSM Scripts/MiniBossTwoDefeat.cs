using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossTwoDefeat : StateMachineBehaviour
{

    private Animation anim;
    private GameObject mini_boss;
    private GameObject mainBoss;
    Animator bossAnim;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        mainBoss = GameObject.FindWithTag("Boss");
        bossAnim = mainBoss.GetComponent<Animator>();
        mini_boss = GameObject.FindWithTag("miniBossTwo");
        anim = mini_boss.GetComponent<Animation>();
        anim.Play("dead");
        bossAnim.SetTrigger("prePhaseOver");
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (GameObject.FindWithTag("laserBeam") != null)
        {
            Destroy(GameObject.FindWithTag("laserBeam"));
        }
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
