using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class hari : MonoBehaviour
{

	Text Hari;
    // Start is called before the first frame update
    void Start()
    {
        Hari = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        Hari.text = "Hari: " + (SceneManager.GetActiveScene().buildIndex - 1).ToString();
    }
}
