using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
	public Transform shootPoint;
	public GameObject bullet;
    // private int delay = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
    	if(Input.GetButtonDown("Fire1"))
    	{
            // if(delay == 0){
              // delay = 50;
              FindObjectOfType<AudioManager>().Play("lempar");
    		  Shoot();
            // }
    	}

        // if(delay > 0)
            // delay --;

    }

    void Shoot()
    {
    	Instantiate(bullet, shootPoint.position, shootPoint.rotation);

    }
}
