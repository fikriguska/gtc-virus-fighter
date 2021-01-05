using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class endScore : MonoBehaviour
{
    // Start is called before the first frame update
	Text EndScore;
    // Start is called before the first frame update
    void Start()
    {
        EndScore = GetComponent<Text> ();
        EndScore.text = "poin: " + score.scoreValue;
    }

    void Update(){
    	 if (Input.anyKey){
				SceneManager.LoadScene(0);
				player.savedScore = 0;
         		score.scoreValue = 0;
         		nyawa.health = 3;
    	 }
    }

}
