using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus : MonoBehaviour
{
	public int health = 100;
	public int RotationSpeed = 10;
	// public double speed = 0.05;
	public bool debug = false;

	 public float delta = 1.5f;  // Amount to move left and right from the start point
     public float speed = 2.0f;

     private Vector3 startPos;
 
     void Start () {
         startPos = transform.position;
     }

	public void FixedUpdate(){
		 // transform.Rotate ( 0, 0,  ( RotationSpeed * Time.deltaTime ) );
         Vector3 v = startPos;
         v.x += delta * Mathf.Sin (Time.time * speed);
         transform.position = v;



	}

	public void TakeDamage(int damage){
		health -= damage;

		if(health <= 0){
			score.scoreValue += 1;
			Die();
		}
	}

	void Die(){
        FindObjectOfType<AudioManager>().Play("virus-mati");
		Destroy(gameObject);
	}
}
