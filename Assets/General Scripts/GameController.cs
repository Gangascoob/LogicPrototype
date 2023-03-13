using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI characterHP;
    public GameObject Boss;
    public float characterHealth = 20.0f;
    public float bossHealth = 100.0f;
    public bool canPlayerBeHit = false;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = Boss.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        characterHP.text = string.Format("{0}", characterHealth);
        if(characterHealth < 1)
        {
            Debug.Log("YA DEAD");
        }
    }

    public void crystalOneHit()
    {
        anim.SetTrigger("crystalOne");
    }

    public void bossStrike()
    {
        Debug.Log("boss hit player");
        characterHealth -= 2.0f;
        //characterHP.text = string.Format("{0}", characterHealth);
    }

    public void playerHittable()
    {
        canPlayerBeHit = true;
    }

    public void playerNotHittable()
    {
        canPlayerBeHit = false;
    }
}
