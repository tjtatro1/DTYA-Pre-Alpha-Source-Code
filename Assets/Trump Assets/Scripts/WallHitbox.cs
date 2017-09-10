using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHitbox : MonoBehaviour {

    private static bool enemyIsHitByWall = false;

    public static void setEnemyIsHitByWall(bool val)
    {
        enemyIsHitByWall = val;
    }
    public static bool getEnemyIsHitByWall()
    {
        return enemyIsHitByWall;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            setEnemyIsHitByWall(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            setEnemyIsHitByWall(false);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (getEnemyIsHitByWall() == true)
        {
            Debug.Log("The wall has hit the enemy!");
        }
        else
        {
            Debug.Log("The wall has missed the enemy!");
        }
    }
}
