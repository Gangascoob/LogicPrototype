using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject Boss;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = Boss.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void crystalOneHit()
    {
        anim.SetTrigger("crystalOne");
    }
}
