using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadFromMainMenu : MonoBehaviour {

    IEnumerator fadeOut()
    {
        GameObject.Find("Black Sprite").GetComponent<Image>().CrossFadeAlpha(255, 3, false);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("First Conversation");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey)
        {
            StartCoroutine(fadeOut());
        }
	}
}
