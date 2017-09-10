using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour {

    GameObject dialogueTrigger;
    GameObject player;
    RPGTalk rpgTalk;
    GameObject dialogueBox;
    GameObject dialogue;
    GameObject speakerName;
    GameObject battleAgainstHero;
    GameObject megalovania;
    private bool convoTriggered = false;
    private int count = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            convoTriggered = true;
        }
    }

    // Use this for initialization
    void Start () {
        dialogueTrigger = GameObject.Find("Ted Cruz Dialogue Trigger");
        player = GameObject.Find("Trump");
        rpgTalk = GameObject.Find("RPGHolder").GetComponent<RPGTalk>();
        dialogueBox = GameObject.Find("dialogue box");
        dialogue = GameObject.Find("Dialogue");
        speakerName = GameObject.Find("Name");
        battleAgainstHero = GameObject.Find("Battle Against a True Hero");
        megalovania = GameObject.Find("Megalovania");
        dialogueBox.SetActive(false);
        dialogue.SetActive(false);
        speakerName.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P) && count == 0)
        {
            dialogueBox.SetActive(true);
            dialogue.SetActive(true);
            speakerName.SetActive(true);
            rpgTalk.lineToStart = 0;
            rpgTalk.lineToBreak = 6;
            rpgTalk.NewTalk();
            GameObject.Find("Enemy Approaching").GetComponent<AudioSource>().Stop();
            battleAgainstHero.GetComponent<AudioSource>().Play();
            count++;
        }
        if (Input.GetKeyDown(KeyCode.O) && count == 1)
        {
            dialogueBox.SetActive(false);
            dialogue.SetActive(false);
            speakerName.SetActive(false);
            count++;
        }
        if (Input.GetKeyDown(KeyCode.P) && count == 2)
        {
            dialogueBox.SetActive(true);
            dialogue.SetActive(true);
            speakerName.SetActive(true);
            rpgTalk.lineToStart = 9;
            rpgTalk.lineToBreak = 10;
            rpgTalk.NewTalk();
            battleAgainstHero.GetComponent<AudioSource>().Stop();
            count++;
        }
        if (Input.GetKeyDown(KeyCode.O) && count == 3)
        {
            dialogueBox.SetActive(false);
            dialogue.SetActive(false);
            speakerName.SetActive(false);
            count++;
        }
        if (Input.GetKeyDown(KeyCode.P) && count == 4)
        {
            dialogueBox.SetActive(true);
            dialogue.SetActive(true);
            speakerName.SetActive(true);
            rpgTalk.lineToStart = 12;
            rpgTalk.lineToBreak = 18;
            rpgTalk.NewTalk();
            megalovania.GetComponent<AudioSource>().Play();
            count++;
        }
        if (Input.GetKeyDown(KeyCode.O) && count == 5)
        {
            dialogueBox.SetActive(false);
            dialogue.SetActive(false);
            speakerName.SetActive(false);
            count++;
        }
        if (Input.GetKeyDown(KeyCode.P) && count == 6)
        {
            dialogueBox.SetActive(true);
            dialogue.SetActive(true);
            speakerName.SetActive(true);
            rpgTalk.lineToStart = 20;
            rpgTalk.lineToBreak = 22;
            rpgTalk.NewTalk();
            megalovania.GetComponent<AudioSource>().Stop();
            count++;
        }
        if (Input.GetKeyDown(KeyCode.O) && count == 7)
        {
            dialogueBox.SetActive(false);
            dialogue.SetActive(false);
            speakerName.SetActive(false);
            count++;
        }
        if (Input.GetKeyDown(KeyCode.P) && count == 8)
        {
            dialogueBox.SetActive(true);
            dialogue.SetActive(true);
            speakerName.SetActive(true);
            rpgTalk.lineToStart = 24;
            rpgTalk.lineToBreak = 29;
            rpgTalk.NewTalk();
            count++;
        }
        if (Input.GetKeyDown(KeyCode.O) && count == 9)
        {
            dialogueBox.SetActive(false);
            dialogue.SetActive(false);
            speakerName.SetActive(false);
            count++;
        }
        if (Input.GetKeyDown(KeyCode.P) && count == 10)
        {
            dialogueBox.SetActive(true);
            dialogue.SetActive(true);
            speakerName.SetActive(true);
            rpgTalk.lineToStart = 31;
            rpgTalk.lineToBreak = 31;
            rpgTalk.NewTalk();
            count++;
        }
        if (Input.GetKeyDown(KeyCode.O) && count == 11)
        {
            dialogueBox.SetActive(false);
            dialogue.SetActive(false);
            speakerName.SetActive(false);
            SceneManager.LoadScene("Credits");
        }
    }
}
