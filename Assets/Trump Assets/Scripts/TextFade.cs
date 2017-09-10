using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {

    IEnumerator FadeLevelText()
    {
        yield return new WaitForSeconds(2.0f);
        GameObject.Find("Level Intro Text").GetComponent<Text>().CrossFadeAlpha(0, 1, false);
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(FadeLevelText());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
