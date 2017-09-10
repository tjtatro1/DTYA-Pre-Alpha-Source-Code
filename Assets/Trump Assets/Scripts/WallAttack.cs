using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAttack : MonoBehaviour
{
    public int wallOffsetX = 8;
    public int wallOffsetY = 12;
    public float wallRiseHeight = 10f;
    public float wallRiseDuration = 3f;
    private static float wallPosX, wallPosY, startTime = 0f;
    private static bool isMoving, isFading = false;
    private static bool onCooldown = false;
    private GameObject wallClone = null;

    public static bool getIsMoving()
    {
        return isMoving;
    }
    public static float getWallPosX()
    {
        return wallPosX;
    }
    public static float getWallPosY()
    {
        return wallPosY;
    }

    void Start(){
		if (Input.GetKeyDown(KeyCode.W) && onCooldown == false)
		{	
			wallClone = GameObject.Find ("Wall");
			float playerX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
			float playerY = GameObject.FindGameObjectWithTag("Player").transform.position.y;
			wallPosX = playerX + 10.0f - wallOffsetX;
			wallPosY = playerY - wallOffsetY;
			wallClone = GameObject.Instantiate(GameObject.Find("Wall"), new Vector2 (wallPosX, wallPosY), Quaternion.identity);
			startTime = Time.time;

			Combat.removeTrumpStamina(3);
			onCooldown = true;
			isMoving = true;

			StartCoroutine(DestroyWall());
		}
		if (isMoving)
		{
			float time = Time.time;
			wallClone.transform.position = new Vector2(wallPosX, Mathf.SmoothStep(wallPosY, wallPosY + wallRiseHeight, (time - startTime)/wallRiseDuration));
		}
		if (isFading)
		{
			float time = Time.time;
			float r = wallClone.GetComponent<SpriteRenderer>().color.r;
			float g = wallClone.GetComponent<SpriteRenderer>().color.g;
			float b = wallClone.GetComponent<SpriteRenderer>().color.b;
			wallClone.GetComponent<SpriteRenderer>().color = new Color(r, g, b, Mathf.SmoothStep(255f, 0f, (startTime - time)/10f));
		}
    }

    void Update()
    {
		Start ();
    }

    IEnumerator DestroyWall()
    {
        yield return new WaitForSeconds(3);
        isMoving = false;
        Destroy(wallClone.GetComponent<BoxCollider2D>());

        yield return new WaitForSeconds(3);
        isFading = true;
        startTime = Time.time;

        yield return new WaitForSeconds(1);
        isFading = false;
        Destroy(wallClone);

        yield return new WaitForSeconds(8);
        onCooldown = false;
    }
}
