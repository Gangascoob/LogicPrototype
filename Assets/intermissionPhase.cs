using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intermissionPhase : StateMachineBehaviour
{

    private Animation anim;
    private GameObject teleportPos;
    private float timer = 0.0f;
    private bool castComplete = false;
    public GameObject projectileBeam;
    private Transform launchPos;
    public float launchVelocity = 40f;
    private Animator bossAnimator;
    private int counter = 0;
    

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {   
        teleportPos = GameObject.FindGameObjectWithTag("teleportPos");
        animator.transform.position = teleportPos.transform.position;
        anim = animator.GetComponent<Animation>();
        anim.Play("idle_combat");
        launchPos = GameObject.FindGameObjectWithTag("launchPos").transform;
        bossAnimator = animator.GetComponent<Animator>();
        Debug.Log("intermission");
        
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        counter += 1;
        Debug.Log(timer + "update timer");
        if(timer > 3)
        {
            animator.transform.Rotate(Vector3.up, 360f * Time.deltaTime / 1f);
            if (counter % 2 == 0)
            {
                GameObject beam = Instantiate(projectileBeam, launchPos.position, launchPos.rotation);
                beam.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
                
            }
           
        }
        if(timer > 5)
        {
            bossAnimator.SetTrigger("intermissionComplete");
        }


    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        anim.Play("idle_normal");
        timer = 0;
        Debug.Log(timer);
        animator.ResetTrigger("intermissionComplete");
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
