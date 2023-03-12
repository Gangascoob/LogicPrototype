using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponHit : MonoBehaviour
{

    public GameObject GameController;
    GameController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = GameController.GetComponent<GameController>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            controller.bossStrike();
        }
    }
}
