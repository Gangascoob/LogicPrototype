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

    public void OnTriggerEnter(Collider collider)
    {
        //MINI BOSS COLLIDER FUNCTIONS (HITTABLE)
        if (collider.gameObject.tag == "miniBoss") {
            gameController.miniBossOneHittable();
        }

        if (collider.gameObject.tag == "miniBossTwo")
        {
            gameController.miniBossTwoHittable();
        }

        //MAIN BOSS COLLIDER FUNCTIONS (HITTABLE)
        if (collider.gameObject.tag == "Boss")
        {
            gameController.bossHittable();
        }

    }

    public void OnTriggerExit(Collider collider)
    {
        //MINI BOSS COLLIDER FUNCTIONS (NOT HITTABLE)
        if (collider.gameObject.tag == "miniBoss")
        {
            gameController.miniBossTwoNotHittable();
        }

        if (collider.gameObject.tag == "miniBossTwo")
        {
            gameController.miniBossTwoNotHittable();
        }

        //MAIN BOSS COLLIDER FUCNTIONS (NOT HITTABLE)
        if (collider.gameObject.tag == "Boss")
        {
            gameController.bossNotHittable();
        }
    }

}
