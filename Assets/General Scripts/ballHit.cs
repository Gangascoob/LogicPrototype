using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballHit : MonoBehaviour
{

    GameController gameController;
    private GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameController>();
        ball = GameObject.FindGameObjectWithTag("laserBeam");

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            gameController.bossStrike();
            Destroy(ball);
        }

        if(player.gameObject.tag == "Floor")
        {
            Destroy(ball);
        }
    }
}
