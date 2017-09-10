using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour {

    Animator anim;
    GameObject cruz;
    bool isRunning = false;
    bool isIdling = false;

	// Use this for initialization
	void Start () {
        cruz = GameObject.Find("Cruz");
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (cruz.GetComponent<EnemyAIBasics>().getVelocityX() < -0.25)
        {
            cruz.GetComponent<SpriteRenderer>().flipX = true;
            isRunning = true;
            isIdling = false;
        }
        else if (cruz.GetComponent<EnemyAIBasics>().getVelocityX() > 0.25)
        {
            cruz.GetComponent<SpriteRenderer>().flipX = false;
            isRunning = true;
            isIdling = false;
        }
        else
        {
            isIdling = true;
            isRunning = false;
        }
        anim.SetBool("isIdling", isIdling);
        anim.SetBool("isRunning", isRunning);
    }
}
