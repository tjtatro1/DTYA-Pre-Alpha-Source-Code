using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexasLevelMusic : MonoBehaviour {

    IEnumerator startMusic()
    {
        yield return new WaitForSeconds(6);
        GameObject.Find("Enemy Approaching").GetComponent<AudioSource>().Play();
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(startMusic());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
