using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public  TextMeshProUGUI noteCounter;
    public  int totalNotes;
    private GachaTable gachaTable;

 

    private void Start()
    {
        noteCounter.text = "Music Notes: " + totalNotes;
    }

    private void Update()
    {
        noteCounter.text = "Music Notes: " + totalNotes; 
    }
}
