using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{

    public GameObject projectileBeam;
    public float launchVelocity = 1400f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject beam = Instantiate(projectileBeam, transform.position, transform.rotation);
            beam.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, launchVelocity, 0));
        }
    }
}
