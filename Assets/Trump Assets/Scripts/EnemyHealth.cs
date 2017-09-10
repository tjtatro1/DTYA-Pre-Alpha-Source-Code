using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int health = 2;
    GameObject player;

    public void enemyHit()
    {
        health--;
        if (player.GetComponent<SpriteRenderer>().flipX == false)
        {
            gameObject.GetComponent<Controller2D>().Move(new Vector2(1f, 0f), false);
        }
        else
        {
            gameObject.GetComponent<Controller2D>().Move(new Vector2(-1f, 0f), false);
        }
    }

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Trump");
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
