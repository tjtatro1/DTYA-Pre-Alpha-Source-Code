using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller2D))]
public class DashAttack : MonoBehaviour
{
    private static bool isDashing = false;
    private static bool enemyIsHit = false;
    private static bool standingOnPlatform = false;
    private static int hitCount = 0;
    private static int missCount = 0;
    private static Vector2 dashAmountVector;


    public static bool getEnemyIsHit()
    {
        return enemyIsHit;
    }

    public static void setEnemyIsHit(bool val)
    {
        enemyIsHit = val;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            setEnemyIsHit(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            setEnemyIsHit(false);
        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (enemyIsHit == true)
            {
                hitCount++;
                Debug.Log(hitCount + " Dash Attack landed!");
            }
            else
            {
                missCount++;
                Debug.Log(missCount + " Dash Attack missed!");
            }
        }
    }
}