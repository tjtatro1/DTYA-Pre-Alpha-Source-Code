using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMenuMovie : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MovieTexture movie = GetComponent<RawImage>().texture as MovieTexture;
        movie.Play();
        movie.loop = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
