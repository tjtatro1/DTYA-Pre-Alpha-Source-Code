using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFadeIn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("Black Sprite").GetComponent<Image>().CrossFadeAlpha(0, 1, false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
