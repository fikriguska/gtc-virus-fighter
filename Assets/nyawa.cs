using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class nyawa : MonoBehaviour
{

	public static int health = 3;
	Text Nyawa;
    // Start is called before the first frame update
    void Start()
    {
        Nyawa = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        Nyawa.text = "Nyawa: " + health;
    }
}
