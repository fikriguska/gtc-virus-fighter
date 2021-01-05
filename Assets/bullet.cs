using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

	public float speed = 20f;
	public int damage = 20;
	public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
		// transform.Rotate ( 0, 0,  40 );
		// Debug.Log(transform.right.x);
		// Debug.Log(transform.right*speed);
        // rb.velocity = transform.right * speed;
        rb.velocity = new Vector3((transform.right.x >= 0 ? 1 : -1 ) * speed, 0, 0);

    }

    void OnTriggerEnter2D(Collider2D hitInfo){
    	virus enemy = hitInfo.GetComponent<virus>();
    	if(enemy != null){
    		enemy.TakeDamage(damage);
    	}

    	if(hitInfo.name != "player" && hitInfo.tag != "masker" && hitInfo.tag != "bullet"){
    		Debug.Log(hitInfo.name);
    		Destroy(gameObject);
    	}
    }

}
