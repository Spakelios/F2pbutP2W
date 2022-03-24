using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public TextMeshProUGUI money;
    
    private void Start()

    {
        money.text = " " + ShowCurrency.totalNotes;
    }
    
}
