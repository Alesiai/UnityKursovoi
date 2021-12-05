using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PLAY : MonoBehaviour
{
    public static bool IsOn = false;

    public GameObject TaskPanel;
    public GameObject NPanel;
    public GameObject InputPanel;
    public GameObject Input;

    public GameObject OTable;
    public GameObject Table;
    public GameObject Key;

    public GameObject PlayButton;
    public GameObject ExitButton;

    public Text TaskText;

    public GameObject OnOffObject;

    public float moveto;
    public GameObject Ust1;
    public GameObject Ust2;
    public GameObject Ust3;
    public GameObject Ust4;


    public GameObject Step1;
    public GameObject Step2;
    public GameObject Step3;
    public GameObject Step4;
    public GameObject Step5;
    public GameObject Step6;
    public GameObject Step7;
    public GameObject Step8;
    public GameObject Step9;
    public GameObject Step10;
    public GameObject Step11;
    public GameObject Step12;
    public GameObject Step13;

    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text;


    public void PlayNow() {
        IsOn = true;

        TaskPanel.SetActive(true);
        NPanel.SetActive(true);
        ExitButton.SetActive(true);

        Step1.SetActive(true);
        Step2.SetActive(true);
        Step3.SetActive(true);
        Step4.SetActive(true);
        Step5.SetActive(true);
        Step6.SetActive(true);
        Step7.SetActive(true);
        Step8.SetActive(true);
        Step9.SetActive(true);
        Step10.SetActive(true);
        Step11.SetActive(true);
        Step12.SetActive(true);
        Step13.SetActive(true);




        PlayButton.transform.Translate(0, moveto, 0);
        ExitButton.transform.Translate(0, moveto, 0);

        Step1.transform.Translate(0, moveto, 0);
        Step2.transform.Translate(0, moveto, 0);
        Step3.transform.Translate(0, moveto, 0);
        Step4.transform.Translate(0, moveto, 0);
        Step5.transform.Translate(0, moveto, 0);
        Step6.transform.Translate(0, moveto, 0);
        Step7.transform.Translate(0, moveto, 0);
        Step8.transform.Translate(0, moveto, 0);
        Step9.transform.Translate(0, moveto, 0);
        Step10.transform.Translate(0, moveto, 0);
        Step11.transform.Translate(0, moveto, 0);
        Step12.transform.Translate(0, moveto, 0);
        Step13.transform.Translate(0, moveto, 0);



        Ust1.SetActive(false);
        Ust2.SetActive(false);
        Ust3.SetActive(false);
        Ust4.SetActive(false);


        TaskText.text = "Шаг 1. Включить установку";
    }

    public void ExitNow()
    {
        IsOn = false;

        TaskPanel.SetActive(false);
        NPanel.SetActive(false);
        ExitButton.SetActive(false);

        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(false);
        Step6.SetActive(false);
        Step7.SetActive(false);
        Step8.SetActive(false);
        Step9.SetActive(false);
        Step10.SetActive(false);
        Step11.SetActive(false);
        Step12.SetActive(false);
        Step13.SetActive(false);

        PlayButton.transform.Translate(0, -moveto, 0);
        ExitButton.transform.Translate(0, -moveto, 0);

        Step1.transform.Translate(0, -moveto, 0);
        Step2.transform.Translate(0, -moveto, 0);
        Step3.transform.Translate(0, -moveto, 0);
        Step4.transform.Translate(0, -moveto, 0);
        Step5.transform.Translate(0, -moveto, 0);
        Step6.transform.Translate(0, -moveto, 0);
        Step7.transform.Translate(0, -moveto, 0);
        Step8.transform.Translate(0, -moveto, 0);
        Step9.transform.Translate(0, -moveto, 0);
        Step10.transform.Translate(0, -moveto, 0);
        Step11.transform.Translate(0, -moveto, 0);
        Step12.transform.Translate(0, -moveto, 0);
        Step13.transform.Translate(0, -moveto, 0);

        Step1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Step13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);


        Ust1.SetActive(true);
        Ust2.SetActive(true);
        Ust3.SetActive(true);
        Ust4.SetActive(true);

        Text1.text = "";
        Text3.text = "";
        Text2.text = "";
        Text.text = "";

        Input.SetActive(false);
        InputPanel.SetActive(false);
        OTable.SetActive(false);
        Table.SetActive(false);

        Debug.Log(OnOff.step);
        if (OnOff.step != 13 && OnOff.step != 0)
        {
            OnOffObject.transform.Translate(0, 0, 0.4f);
            IsOn = false;
        }
        if(OnOff.step != 12 && OnOff.step != 1) 
        {
            Key.transform.Rotate(5.0f, 0.0f, 0.0f, Space.Self);
            KeyMover.KeyDown = false;
        }
        OnOff.step = 0;
    }
}
