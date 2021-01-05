using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject masker;
	public Transform maskerPoint;
	private bool maskered = false;
	private GameObject childObject;
	private int delay = 0;

	// private float trans = 0.5f;
	// private  col = gameObject.GetComponent<Renderer> ().material.color;
	private  GameObject currentGameObject;
	private Color col;
	public static int savedScore = 0;


	void Start()
{
    currentGameObject = gameObject;
    FindObjectOfType<AudioManager>().Play("background-music");

}


void ChangeAlpha(Material mat, float alphaVal)
{
    Color oldColor = mat.color;
    Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
    mat.SetColor("_Color", newColor);

}
		
	void FixedUpdate(){
		 Debug.Log(delay);

		if(delay > 0)
			delay--;
		else if(delay == 0){
    		ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, 1f);
    		delay--;
		}

	}

    void OnTriggerEnter2D(Collider2D hitInfo){
    	if(hitInfo.tag == "enemy"){
    		if(maskered){
    			Destroy(childObject);
    			maskered = false;
    			delay = 100;
    			// gameObject.GetComponent<Renderer> ().material.color.a = 0.5f;
    			// col.a = 0.2f;
    			ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, 0.5f);


    		}
    		else if(delay == -1){
    			nyawa.health--;


    			// yield return new WaitForSeconds(1);

         		if(nyawa.health == 0){
					SceneManager.LoadScene(1);
				}
				else{
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         			score.scoreValue = savedScore;
				}


    		}

    	}

    	else if(hitInfo.tag == "masker"){
    		Destroy(hitInfo.gameObject);
            FindObjectOfType<AudioManager>().Play("masker");


    		if(!maskered){

    			childObject = Instantiate(masker) as GameObject;
     			childObject.transform.parent = gameObject.transform;
     			childObject.transform.position = maskerPoint.position;
     		}
     		maskered = true;
	    	// Instantiate(masker, maskerPoint.position, maskerPoint.rotation);
    		// Destroy();

    	}
    	else if(hitInfo.name == "DeathLine"){

         	nyawa.health--;
         	// yield return new WaitForSeconds(1);

         	if(nyawa.health == 0){
				SceneManager.LoadScene(1);

			}
			else{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         		score.scoreValue = savedScore;
			}




    	}
    	else if(hitInfo.name == "finish"){
         	savedScore = score.scoreValue;
         	if(SceneManager.GetActiveScene().buildIndex == 3){
				SceneManager.LoadScene(1);

         	}
         	else
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			// Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
			// SceneManager.LoadScene(0);

    	}
    }


}
