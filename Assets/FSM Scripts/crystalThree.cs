using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalThree : MonoBehaviour
{
    public GameObject GameController;
    GameController controller;
   
    public GameObject child;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameController.GetComponent<GameController>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider beam)
    {
        if (beam.gameObject.tag == "laserBeam")
        {
            controller.pillarThreeHit();
            Destroy(child);
        }
    }

}
