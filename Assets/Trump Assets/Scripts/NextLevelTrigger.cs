using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelTrigger : MonoBehaviour {
    public string levelName = "DC Level";
    private bool isFading = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.Find("Black Sprite").GetComponent<Image>().CrossFadeAlpha(255, 1, false);
            isFading = true;
        }
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(levelName);
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (isFading == true)
        {
            StartCoroutine(LoadLevel());
        }
	}
}
