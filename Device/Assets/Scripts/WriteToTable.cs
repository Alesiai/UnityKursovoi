using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WriteToTable : MonoBehaviour
{
    public Text InputText;
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text;
    public static double n1 = 0, n2 = 0, n3 = 0, n = 0;



    public GameObject Step5;
    public GameObject Step8;
    public GameObject Step11;

    public void PlayNow()
    {

        if (OnOff.step == 4)
        {
            Text1.text = InputText.text;

            n1 = Convert.ToDouble(InputText.text);
            n = n1;

            Text.text = Convert.ToString(Math.Round(n, 3, MidpointRounding.AwayFromZero));
            OnOff.step = 5;
            Step5.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

        }
        else if (OnOff.step == 7)
        {
            Text2.text = InputText.text;

            n2 = Convert.ToDouble(InputText.text);
            n = (n1 + n2) / 2;

            Text.text = Convert.ToString(Math.Round(n, 2, MidpointRounding.AwayFromZero));
            OnOff.step = 8;
            Step8.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

        }
        else if (OnOff.step == 10)
        {
            Text3.text = InputText.text;

            n3 = Convert.ToDouble(InputText.text);
            n = (n1 + n2 + n3) / 3;

            Text.text = Convert.ToString(Math.Round(n, 3, MidpointRounding.AwayFromZero));
            OnOff.step = 11;
            Step11.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
        }
    }

}
