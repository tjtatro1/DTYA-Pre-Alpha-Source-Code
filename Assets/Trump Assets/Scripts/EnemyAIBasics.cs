using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIBasics : MonoBehaviour
{

    public string enemyName;
    public float targetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemySpeed;
    public float damping;
    private float accelerationTimeAirborne = .2f;
    private float accelerationTimeGrounded = .1f;
    private float gravity;
    private float velocityXSmoothing;
    private Vector3 relativeDirection;
    private Vector3 velocity;
    private Vector2 direction;
    private Controller2D controller;
    Rigidbody2D theRigidbody;
    Renderer myRender;
    GameObject trump;

    public float getVelocityX()
    {
        return velocity.x;
    }

    public float getVelocityY()
    {
        return velocity.y;
    }

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<Controller2D>();
        myRender = GetComponent<Renderer>();
        theRigidbody = GetComponent<Rigidbody2D>();
        trump = GameObject.Find("Trump");
        gravity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        targetDistance = Vector3.Distance(transform.position, trump.transform.position);
        if (targetDistance < enemyLookDistance)
        {
            myRender.material.color = Color.red;
            lookAtPlayer();
            calculateVelocity();
            if(targetDistance > attackDistance)
            {
                controller.Move(velocity * Time.deltaTime, direction);
            }

        }

    }

    void lookAtPlayer()
    {
        relativeDirection = (trump.transform.position - transform.position).normalized;
        direction.x = relativeDirection.x;
        direction.y = relativeDirection.y;
    }

    void calculateVelocity()
    {
        float targetVelocityX = direction.x * enemySpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below ? accelerationTimeGrounded : accelerationTimeAirborne));
        velocity.y += gravity * Time.deltaTime;
    }
}


