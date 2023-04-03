using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaOfEffect : MonoBehaviour
{
    GameController gameController;
    private float timer = 0;
    private float vectorX = 0.4f;
    private float vectorY = 0.4f;
    private float vectorZ = 0.4f;
    private bool playerIn = false;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameController>();
    }


   


    // Update is called once per frame
    void FixedUpdate()
    {
        timer += 0.02f;
        vectorX += 0.0005f;
        vectorY += 0.0005f;
        vectorZ += 0.0005f;
        this.transform.localScale = new Vector3(vectorX, vectorY, vectorZ);
        if(timer > 1 && playerIn == true)
        {
            timer = 0.0f;
            gameController.aoeStrike();
        }
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("aoe enter");
        if(collider.gameObject.tag == "Player")
        {
            playerIn = true;
        }
        
    }
    
    public void OnTriggerExit(Collider collider)
    {
       if(collider.gameObject.tag == "Player")
        {
            playerIn = false;
        }
    }
}
