using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaSystem : MonoBehaviour {

    GameObject stamina1, stamina2, stamina3, stamina4, stamina5;

    IEnumerator StaminaRegen()
    {
        if (Combat.getTrumpStamina() < 5)
        {
            yield return new WaitForSeconds(2);
            Combat.regenTrumpStamina();
        }
    }

        // Use this for initialization
    void Start()
    {
        stamina1 = GameObject.Find("Yellow Stamina 1");
        stamina2 = GameObject.Find("Yellow Stamina 2");
        stamina3 = GameObject.Find("Yellow Stamina 3");
        stamina4 = GameObject.Find("Yellow Stamina 4");
        stamina5 = GameObject.Find("Yellow Stamina 5");
    }

        // Update is called once per frame
    void Update()
    {
        if (Combat.getTrumpStamina() < 5)
        {
            StartCoroutine(StaminaRegen());
        }
        if (Combat.getTrumpStamina() == 5)
        {
            stamina5.SetActive(true);
            stamina4.SetActive(true);
            stamina3.SetActive(true);
            stamina2.SetActive(true);
            stamina1.SetActive(true);
        }
        else if (Combat.getTrumpStamina() == 4)
        {
            stamina5.SetActive(false);
            stamina4.SetActive(true);
            stamina3.SetActive(true);
            stamina2.SetActive(true);
            stamina1.SetActive(true);
        }
        else if (Combat.getTrumpStamina() == 3)
        {
            stamina5.SetActive(false);
            stamina4.SetActive(false);
            stamina3.SetActive(true);
            stamina2.SetActive(true);
            stamina1.SetActive(true);
        }
        else if (Combat.getTrumpStamina() == 2)
        {
            stamina5.SetActive(false);
            stamina4.SetActive(false);
            stamina3.SetActive(false);
            stamina2.SetActive(true);
            stamina1.SetActive(true);
        }
        else if (Combat.getTrumpStamina() == 1)
        {
            stamina5.SetActive(false);
            stamina4.SetActive(false);
            stamina3.SetActive(false);
            stamina2.SetActive(false);
            stamina1.SetActive(true);
        }
        else if (Combat.getTrumpStamina() == 0)
        {
            stamina5.SetActive(false);
            stamina4.SetActive(false);
            stamina3.SetActive(false);
            stamina2.SetActive(false);
            stamina1.SetActive(false);
        }
    }
}
