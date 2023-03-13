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
    }

    public void crystalOneHit()
    {
        anim.SetTrigger("crystalOne");
    }

    public void bossStrike()
    {
        Debug.Log("boss hit player");
        //characterHP.text = string.Format("{0}", characterHealth);
    }
}
