using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveLine : MonoBehaviour
{
    int move = 0;
    public GameObject Bridge;
    int totalLength = 0;
    
    public GameObject Step3;
    public GameObject Step6;
    public GameObject Step9;

    void OnMouseOver()
    {
        if (move == 0 && OnOff.step == 5 )
        {
            Bridge.transform.Translate(-(ThousandResistanceMover.movePast), 0, 0);
            ThousandResistanceMover.movePast = 0.0f;
            move = 1; 
        }
        
        if (move == 1 && OnOff.step == 8)
        {
            Bridge.transform.Translate(-(ThousandResistanceMover.movePast), 0, 0);
            ThousandResistanceMover.movePast = 0.0f;
            move = 0;
        }

        if (OnOff.step == 2 || OnOff.step == 5 || OnOff.step == 8)
        {
            //<-
            if (Input.GetMouseButtonDown(0) && totalLength != 0)
            {
                if (totalLength == 5)
                {
                    transform.Translate(0.2f, 0, 0);
                    totalLength -= 5;
                }
                else if (totalLength == 10)
                {
                    transform.Translate(0.3f, 0, 0);
                    totalLength -= 5;
                }
                else
                {
                    transform.Translate(0.35f, 0, 0);
                    totalLength -= 5;
                }
            }
            //->
            if (Input.GetMouseButtonDown(1) && totalLength != 90)
            {
                if (totalLength == 0)
                {
                    transform.Translate(-0.2f, 0, 0);
                    totalLength += 5;
                }
                else if (totalLength == 5)
                {
                    transform.Translate(-0.3f, 0, 0);
                    totalLength += 5;
                }
                else
                {
                    transform.Translate(-0.35f, 0, 0);
                    totalLength += 5;
                }
            }
            
            if(OnOff.step == 2 && totalLength == 45)
            {
                OnOff.step = 3;
                Step3.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            }
            if (OnOff.step == 5 && totalLength == 40)
            {
                OnOff.step = 6;
                Step6.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            }
            if (OnOff.step == 8 && totalLength == 50)
            {
                OnOff.step = 9;
                Step9.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            }

        }
    }
}
