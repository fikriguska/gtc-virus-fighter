using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("background-music-menu");
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
