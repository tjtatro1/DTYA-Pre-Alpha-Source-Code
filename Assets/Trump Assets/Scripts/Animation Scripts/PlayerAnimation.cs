using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    Animator anim;
    GameObject player;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Trump");
	}
	
	// Update is called once per frame
	void Update () {
        bool isArrowKeyPressed = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow);
        bool isKeyPressed = Input.anyKey;
        bool isJumping = player.GetComponent<Controller2D>().collisions.below == false;
        bool isPunching = Input.GetKey(KeyCode.Q);
        anim.SetBool("isJumping", isJumping);
        anim.SetBool("isPunching", isPunching);
        anim.SetBool("isRunning", isArrowKeyPressed && !isJumping);
        anim.SetBool("isIdling", !isKeyPressed && !isJumping);
        if (player.GetComponent<Player>().getVelocityX() < 0)
        {
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
