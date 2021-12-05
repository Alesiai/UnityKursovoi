using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThousandResistanceMover : MonoBehaviour
{
    public static double totalResistance = 1111.11;
    public static double thisResistance = 1000.00;
    public static string waitingResistanseFirst = Convert.ToString(2951.34);
    public static string waitingResistanseSecond = Convert.ToString(3762.56);
    public static string waitingResistanseThird = Convert.ToString(2193.82);
    public GameObject Bridge;

    public GameObject Step4;
    public GameObject Step7;
    public GameObject Step10;

    public static float movePast = 0.0f;

    public void MoveBride(double totalResistance)
    {
        float moveFuture = 0.0f;
        if (OnOff.step == 3)
        {
            double num1 = 1951.34, num2 = 3951.34, num3 = 2951.34;

            if (totalResistance == num3)
                moveFuture = 0.35f;

            else if (num1 > totalResistance)
                moveFuture = 0.00f;

            else if (num2 < totalResistance)
                moveFuture = 0.7f;

            else if (totalResistance < (((num3 - num2) / 2) + num2) && totalResistance > num3) // < 3451.34
                moveFuture = 0.516f;

            else if (totalResistance > (((num3 - num2) / 2) + num2) && totalResistance > num3) // > 3451.34
                moveFuture = 0.628f;

            else if (totalResistance > (((num3 - num1) / 2) + num1) && totalResistance < num3) // > 2451.34
                moveFuture = 0.233f;

            else if (totalResistance < (((num3 - num1) / 2) + num1) && num1 < totalResistance) // < 2451.34
                moveFuture = 0.116f;
        }
        if (OnOff.step == 6)
        {
            double num1 = 2762.56, num2 = 4762.56, num3 = 3762.56;


            if (Convert.ToString(ThousandResistanceMover.totalResistance).Equals(ThousandResistanceMover.waitingResistanseSecond))
                moveFuture = 0.35f;

            else if (num1 > totalResistance)
                moveFuture = 0.00f;

            else if (num2 < totalResistance)
                moveFuture = 0.7f;

            else if (totalResistance < (((num3 - num2) / 2) + num2) && totalResistance > num3)
                moveFuture = 0.516f;

            else if (totalResistance > (((num3 - num2) / 2) + num2) && totalResistance > num3)
                moveFuture = 0.628f;

            else if (totalResistance > (((num3 - num1) / 2) + num1) && totalResistance < num3)
                moveFuture = 0.233f;

            else if (totalResistance < (((num3 - num1) / 2) + num1) && num1 < totalResistance)
                moveFuture = 0.116f;
        }
        if (OnOff.step == 9)
        {
            double num1 = 1193.82, num2 = 3193.82, num3 = 2193.82;

            if (Convert.ToString(ThousandResistanceMover.totalResistance).Equals(ThousandResistanceMover.waitingResistanseThird))
                moveFuture = 0.35f;

            else if (num1 > totalResistance)
                moveFuture = 0.00f;

            else if (num2 < totalResistance)
                moveFuture = 0.7f;

            else if (totalResistance < (((num3 - num2) / 2) + num2) && totalResistance > num3) // < 3451.34
                moveFuture = 0.516f;

            else if (totalResistance > (((num3 - num2) / 2) + num2) && totalResistance > num3) // > 3451.34
                moveFuture = 0.628f;

            else if (totalResistance > (((num3 - num1) / 2) + num1) && totalResistance < num3) // > 2451.34
                moveFuture = 0.233f;

            else if (totalResistance < (((num3 - num1) / 2) + num1) && num1 < totalResistance) // < 2451.34
                moveFuture = 0.116f;
        }
        Bridge.transform.Translate(-(movePast), 0, 0);
        Bridge.transform.Translate(moveFuture, 0, 0);

        movePast = moveFuture;
    }
    
    void OnMouseOver()
    {
        if (OnOff.step == 3 || OnOff.step == 6 || OnOff.step == 9)
        {
            
            //<-
            if (Input.GetMouseButtonDown(0) && thisResistance != 10000.00)
            {
                transform.Rotate(0.0f, -31f, 0.0f, Space.Self);
                thisResistance += 1000.00;
                totalResistance += 1000.00;
                MoveBride(totalResistance);
            }
            //->
            if (Input.GetMouseButtonDown(1) && thisResistance != 1000.00)
            {
                transform.Rotate(0.0f, 31f, 0.0f, Space.Self);
                thisResistance -= 1000.00;
                totalResistance -= 1000.00;
                MoveBride(totalResistance);
            }

            if (OnOff.step == 3) 
            {
                if (Convert.ToString(totalResistance).Equals(waitingResistanseFirst))
                { 
                    OnOff.step = 4;
                    Step4.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
                }
                else
                {
                    OnOff.step = 3;
                }
            }

            if (OnOff.step == 6)
            {
                if (Convert.ToString(totalResistance).Equals(waitingResistanseSecond))
                {
                    OnOff.step = 7;
                    Step7.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
                }
                else
                {
                    OnOff.step = 6;
                }
            }
            
            if (OnOff.step == 9)
            {
                 
                if (Convert.ToString(totalResistance).Equals(waitingResistanseThird)) 
                {
                    OnOff.step = 10;
                    Step10.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
                }
                else
                {
                    OnOff.step = 9;
                }
            }
            
        }
    }
}
