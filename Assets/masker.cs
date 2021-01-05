using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masker : MonoBehaviour
{

    // Start is called before the first frame update

    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;

    private Vector3 startPos;

    void Start()
    {
         startPos = transform.position;
    }

    void FixedUpdate(){
    	 Vector3 v = startPos;
         v.y += delta * Mathf.Cos (Time.time * speed);
         transform.position = v;

    }

    // Update is called once per frame
    // void FixedUpdate()
    // {
    //     //get the objects current position and put it in a variable so we can access it later with less code
    //     Vector3 pos = transform.position;
    //     //calculate what the new Y position will be
    //     float newY = Mathf.Sin(Time.time * speed);
    //     //set the object's Y to the new calculated Y
    //     transform.position = new Vector3(pos.x, newY, pos.z);    
    // }

    // Vector3 posOffset = new Vector3 ();
    // Vector3 tempPos = new Vector3 ();
    // public float frequency = 1f;
    //  public float amplitude = 0.5f;

    // void Update() {

    // 	tempPos = posOffset;
    //     tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
    //     transform.y = tempPos.y;
    //  }
}
