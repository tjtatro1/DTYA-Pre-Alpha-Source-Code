using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Combat.getTrumpHealth () == 4) 
		{
			Destroy(GameObject.Find ("Red Heart 5"));
		}
        if (Combat.getTrumpHealth() == 3)
        {
			Destroy(GameObject.Find ("Red Heart 4"));
        }
        if (Combat.getTrumpHealth() == 2)
        {
			Destroy(GameObject.Find ("Red Heart 3"));
        }
        if (Combat.getTrumpHealth() == 1)
        {
			Destroy(GameObject.Find ("Red Heart 2"));
        }
        if (Combat.getTrumpHealth() == 0)
        {
			Destroy(GameObject.Find ("Red Heart 1"));
        }
    }
}
