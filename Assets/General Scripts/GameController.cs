using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI characterHP;
    public TextMeshProUGUI bossHP;
    public GameObject Boss;
    public float characterHealth = 20.0f;
    public float bossHealth = 100.0f;
    public bool canPlayerBeHit = false;
    public bool canBossBeHit = false;
    public bool phaseOneOver = false;
    public bool intermissionTriggerOne = false;
    public bool intermissionTriggerTwo = false;
    public bool intermissionTriggerThree = false;
    public bool intermissionTriggerFour = false;
    public bool bossAlive = true;
    Animator anim;

    public bool pillarOne = false;
    public bool pillarTwo = false;
    public bool pillarThree = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = Boss.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        characterHP.text = string.Format("{0}", characterHealth);
        bossHP.text = string.Format("{0}", bossHealth);
        if (characterHealth < 1)
        {
            Debug.Log("YA DEAD");
        }
        if(bossHealth < 85 && intermissionTriggerOne == false)
        {
            anim.SetTrigger("intermission");
            intermissionTriggerOne = true;
        }
        
        if(bossHealth < 80 && bossHealth > 60)
        {
            if(GameObject.FindWithTag("laserBeam") != null)
            {
                Destroy(GameObject.FindWithTag("laserBeam"));
            }
        }
        
        if(bossHealth < 65 && intermissionTriggerTwo == false)
        {
            anim.SetTrigger("intermission");
            intermissionTriggerTwo = true;
        }
        
        if (bossHealth < 60 && bossHealth > 40)
        {
            if (GameObject.FindWithTag("laserBeam") != null)
            {
                Destroy(GameObject.FindWithTag("laserBeam"));
            }
        }
        
        if(bossHealth < 45 && intermissionTriggerThree == false)
        {
            anim.SetTrigger("intermission");
            intermissionTriggerThree = true;
        }
        
        if (bossHealth < 40 && bossHealth > 20)
        {
            if (GameObject.FindWithTag("laserBeam") != null)
            {
                Destroy(GameObject.FindWithTag("laserBeam"));
            }
        }

        if (bossHealth < 25 && intermissionTriggerFour == false)
        {
            anim.SetTrigger("intermission");
            intermissionTriggerFour = true;
        }

        if (bossHealth < 5 && bossAlive == true)
        {
            anim.SetTrigger("bossDead");
        }

    }

    public void pillarOneHit()
    {

        if(pillarOne == false)
        {
            pillarOne = true;
        }
       
        if(pillarTwo == true && pillarThree == true && phaseOneOver == false)
        {
            phaseOneOver = true;
            anim.SetTrigger("pillarsDestroyed");
        }
    }

    public void pillarTwoHit()
    {
        if(pillarTwo == false)
        {
            pillarTwo = true;
        }

        
        if(pillarOne == true && pillarThree == true && phaseOneOver == false)
        {
            phaseOneOver = true;
            anim.SetTrigger("pillarsDestroyed");
        }
    }

    public void pillarThreeHit()
    {

        if(pillarThree == false)
        {
            pillarThree = true;
        }
        
        if(pillarOne == true && pillarTwo == true && phaseOneOver == false)
        {
            phaseOneOver = true;
            anim.SetTrigger("pillarsDestroyed");
        }
    }

    public void bossStrike()
    {
        Debug.Log("boss hit player");
        characterHealth -= 2.0f;
        //characterHP.text = string.Format("{0}", characterHealth);
    }

    public void playerStrike()
    {
        bossHealth -= 5.0f;

        /*
        for (int i = 20; i > 0; i--)
        {
            if (GameObject.FindWithTag("laserBeam") != null)
            {
                Destroy(GameObject.FindWithTag("laserBeam"));
            }
        }
        */
    }

    public void playerHittable()
    {
        canPlayerBeHit = true;
    }

    public void playerNotHittable()
    {
        canPlayerBeHit = false;
    }

    public void bossHittable()
    {
        canBossBeHit = true;
    }

    public void bossNotHittable()
    {
        canBossBeHit = false;
    }
}
