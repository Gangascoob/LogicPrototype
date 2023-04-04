using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class attack : MonoBehaviour
{
    GameController gameController;
    Animator animator;
    

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        gameController = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }

    private void Attack()
    {
        InputSystem.DisableDevice(Keyboard.current);

        animator.SetTrigger("Attack");

        //MINI BOSS ATTACK FUNCTIONS
        if (gameController.canMiniBossOneBeHit == true && timer > 1.0f)
        {
            gameController.playerStrikeMiniBossOne();
            timer = 0;
        }

        if (gameController.canMiniBossTwoBeHit == true && timer > 1.0f)
        {
            gameController.playerStrikeMiniBossTwo();
            timer = 0;
        }

        //MAIN BOSS ATTACK FUNCTION
        if (gameController.canBossBeHit == true && timer > 1.0f)
        {
            gameController.playerStrike();
            timer = 0;
        }

        StartCoroutine(Wait());

        InputSystem.EnableDevice(Keyboard.current);
    }
}
