using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttackCollider : MonoBehaviour
{
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Boss")
        {
            gameController.bossHittable();
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Boss")
        {
            gameController.bossNotHittable();
        }
    }

}
