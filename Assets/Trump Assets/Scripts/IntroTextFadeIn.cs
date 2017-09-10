using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTextFadeIn : MonoBehaviour {

    GameObject date;
    GameObject location;
    GameObject blackSprite;

    IEnumerator intro()
    {
        yield return new WaitForSeconds(2);
        location.GetComponent<Text>().CrossFadeAlpha(255, 3, false);
        yield return new WaitForSeconds(3);
        location.GetComponent<Text>().CrossFadeAlpha(0, 1, false);
        date.GetComponent<Text>().CrossFadeAlpha(0, 1, false);
        blackSprite.GetComponent<Image>().CrossFadeAlpha(0, 1, false);
    }

    // Use this for initialization
    void Start () {
        date = GameObject.Find("Date");
        location = GameObject.Find("Location");
        blackSprite = GameObject.Find("Black Sprite");
        date.GetComponent<Text>().CrossFadeAlpha(255, 3, false);
        StartCoroutine(intro());
	}
}
