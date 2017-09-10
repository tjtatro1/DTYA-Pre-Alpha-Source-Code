using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {

    private static bool enemyIsInHitbox = false;
    GameObject enemyHit;
    private static int hitCount = 0;
    private static int missCount = 0;

    public static bool getEnemyIsInHitbox()
    {
        return enemyIsInHitbox;
    }
    public static void setEnemyIsHit(bool val)
    {
        enemyIsInHitbox = val;
    }
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyIsInHitbox = true;
            enemyHit = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyIsInHitbox = false;
        }
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q) && enemyIsInHitbox == true)
        {
            enemyHit.GetComponent<EnemyHealth>().enemyHit();
            hitCount++;
            Debug.Log(hitCount + " punches landed!");
        }
        else if (Input.GetKeyDown(KeyCode.Q) && enemyIsInHitbox == false)
        {
            missCount++;
            Debug.Log(missCount + " punches missed!");
        }
	}
}
