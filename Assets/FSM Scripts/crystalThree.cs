using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalThree : MonoBehaviour
{
    public GameObject GameController;
    GameController controller;
    ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameController.GetComponent<GameController>();
        particles = this.GetComponent<ParticleSystem>();
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
            particles.Stop();
        }
    }

}
