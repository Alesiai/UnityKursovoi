using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Tasks : MonoBehaviour
{
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

    public GameObject WriteToTable;
    public GameObject OTable;
    public GameObject InputToTable;
    public GameObject Table;

    public Text TaskText;

    public Text InputText;

    public void PlayNow()
    {
        if (OnOff.step == 0)
            TaskText.text = "Шаг 1. Включите установку";
        else if (OnOff.step == 1)
        {
            Step1.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

            TaskText.text = "Шаг 2. Замкните ключ (ЛКМ - замкнуть, ПКМ - размкнуть)";
        }
        else if (OnOff.step == 2)
        {
            Step2.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

            TaskText.text = "Шаг 3. Поставьте ползунок линейки на отмекту 45см (ЛКМ - левее, ПКМ - правее)";
        }
        else if (OnOff.step == 3)
        {
            Step3.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

            TaskText.text = "Шаг 4. Подберите такое сопротивление, чтобы стрелка моста Кирхгоффа указывала на 0 (ЛКМ - против чаосовй стрелки, ПКМ - по часовой стрелке)";
        }
        else if (OnOff.step == 4)
        {
            Step4.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

            WriteToTable.SetActive(true);
            OTable.SetActive(true);
            InputToTable.SetActive(true);

            OpenTable.clicks = 0;

            TaskText.text = "Шаг 5. Занесте полученное сопротивление в таблицу";
        }
        else if (OnOff.step == 5)
        {
            Step5.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

            WriteToTable.SetActive(false);
            OTable.SetActive(false);
            InputToTable.SetActive(false);
            Table.SetActive(false);

            InputText.text = "";


            TaskText.text = "Шаг 6. Поставьте ползунок линейки на отмекту 40см (ЛКМ - левее, ПКМ - правее)";
        }
        else if (OnOff.step == 6)
        {
            Step6.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

            TaskText.text = "Шаг 7. Подберите такое сопротивление, чтобы стрелка моста Кирхгоффа указывала на 0 (ЛКМ - против чаосовй стрелки, ПКМ - по часовой стрелке)";
        }
        else if (OnOff.step == 7)
        {
            Step7.GetComponent<Image>().color = new Color32(157, 255, 155, 255);

            WriteToTable.SetActive(true);
            OTable.SetActive(true);
            InputToTable.SetActive(true);
            OpenTable.clicks = 0;

            TaskText.text = "Шаг 8. Занесте полученное сопротивление в таблицу";
        }
        else if (OnOff.step == 8)
        {

            Step8.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            WriteToTable.SetActive(false);
            OTable.SetActive(false);
            InputToTable.SetActive(false);
            Table.SetActive(false);
            InputText.text = "";
            TaskText.text = "Шаг 9. Поставьте ползунок линейки на отмекту 50см (ЛКМ - левее, ПКМ - правее)";
        }
        else if (OnOff.step == 9)
        {

            Step9.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            
            TaskText.text = "Шаг 10. Подберите такое сопротивление, чтобы стрелка моста Кирхгоффа указывала на 0 (ЛКМ - против чаосовй стрелки, ПКМ - по часовой стрелке)";
        }
        else if (OnOff.step == 10)
        {
            Step10.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            WriteToTable.SetActive(true);
            OTable.SetActive(true);
            InputToTable.SetActive(true);
            OpenTable.clicks = 0;

            TaskText.text = "Шаг 11. Занесте полученное сопротивление в таблицу";
        }
        else if (OnOff.step == 11)
        {
            Step11.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            WriteToTable.SetActive(false);
            InputToTable.SetActive(false);
            Table.SetActive(false);
            InputText.text = "";
            OpenTable.clicks = 0;
            TaskText.text = "Шаг 12. Разомкните ключ (ЛКМ - замкнуть, ПКМ - размкнуть)";
        }
        else if (OnOff.step == 12)
        {
            OpenTable.clicks = 0;
            Step12.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            TaskText.text = "Шаг 13. Выключите установку";
        }
        else if (OnOff.step == 13)
        {
            Step13.GetComponent<Image>().color = new Color32(157, 255, 155, 255);
            OpenTable.clicks = 0;
            TaskText.text = "Поздравляю, Вы выполнили измерение спотивления мостовым методом, результат указан в крайней справа колонке таблицы";
        }
    }

}
