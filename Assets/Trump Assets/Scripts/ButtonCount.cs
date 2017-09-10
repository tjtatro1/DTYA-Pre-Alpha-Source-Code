using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCount : MonoBehaviour
{

    public static float buttonCooler = 0.5f;
    public static int buttonCount = 0;
    public static bool buttonBool = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.anyKeyDown)
        {

            if (buttonCooler > 0 && buttonCount == 1)
            {
                buttonBool = true;
            }
            else
            {
                buttonCooler = 0.5f;
                buttonCount += 1;
                buttonBool = false;
            }
        }

        if (buttonCooler > 0)
        {

            buttonCooler -= 1 * Time.deltaTime;

        }
        else
        {
            buttonCount = 0;
        }
    }
}