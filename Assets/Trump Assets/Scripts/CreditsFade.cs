using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsFade : MonoBehaviour {

    GameObject title;

    IEnumerator credits()
    {
        yield return new WaitForSeconds(1);
        title.GetComponent<Text>().CrossFadeAlpha(255, 3, false);
        yield return new WaitForSeconds(6);
        title.GetComponent<Text>().CrossFadeAlpha(0, 3, false);
        yield return new WaitForSeconds(3);
        Credits.getInstance().beginCredits();
    }

	// Use this for initialization
	void Start () {
        title = GameObject.Find("Title");
        StartCoroutine(credits());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
