using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseOneBehaviour : StateMachineBehaviour
{

    private Transform playerPos;
    private float timer = 0.0f;
    public GameObject projectileBeam;
    public float launchVelocity = 1400f;
    public Transform launchPos;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        launchPos = GameObject.FindGameObjectWithTag("launchPos").transform;
        //projectileBeam = GameObject.FindGameObjectWithTag("laserBeam");
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        launchPos = GameObject.FindGameObjectWithTag("launchPos").transform;
        Debug.Log("PhaseOne");
        //Debug.Log(timer);

        animator.transform.LookAt(playerPos);

        if (timer % 2 < 0.5)
        {
            timer += 0.5f;
            //Debug.Log("Timer tick");
            GameObject beam = Instantiate(projectileBeam, launchPos.position, launchPos.rotation);
            beam.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
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
