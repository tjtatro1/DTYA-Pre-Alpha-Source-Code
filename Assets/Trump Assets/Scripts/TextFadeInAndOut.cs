using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeInAndOut : MonoBehaviour {
	Vector4 vector;
	float fadeRate=0.1f;
	private float interval = 0.15f;
	private float nextTime = 0;

	void fadeOut(){
		vector = GetComponent<Text> ().color;
		vector.w -= fadeRate;
		GetComponent<Text> ().color = vector;
	}

	void fadeIn(){
		vector = GetComponent<Text> ().color;
		vector.w += fadeRate;
		GetComponent<Text> ().color = vector;
	}

	void Start()
	{
		vector = GetComponent<Text> ().color;
		if (vector.w >= 0.0f)
			fadeOut ();
		else
			while(vector.w <= 1.0f)
			{
				fadeIn ();
			}
		//start.GetComponent<Text>().material.color.a = temp;
	}
	void Update(){
		if (Time.time >= nextTime) {
			Start ();
			//do something here every interval seconds

			nextTime += interval;

		}

	}
}
