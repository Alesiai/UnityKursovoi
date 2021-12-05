using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OpenTable : MonoBehaviour
{
    public GameObject Table;
    public static int clicks = 0;

    public void PlayNow()
    {
        if (clicks % 2 == 0)
        {
            Table.SetActive(true);
            clicks++;
        }
        else 
        {
            Table.SetActive(false);
            clicks++;
        }
        
    }
}
