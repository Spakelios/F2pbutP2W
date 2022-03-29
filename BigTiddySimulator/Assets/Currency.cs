using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public TextMeshProUGUI money;
    public TextMeshProUGUI Level;
    public Button button;
    public Animator ponytail, glasses,wall;
    

    private void Update()
    {

        {
            money.text = "Notes: " + ShowCurrency.totalNotes;
            Level.text = "Level: " + ShowCurrency.level;
        }

        if (ShowCurrency.level == 3)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
        
        
        if (ShowCurrency.ponytail == 2)
        {
            ponytail.GetComponent<Animator>().Play("organSwap");
        }
        
        if (ShowCurrency.wall == 2)
        {
            wall.GetComponent<Animator>().Play("trumpetSwap");
        }
        
        if (ShowCurrency.glasses == 2)
        {
            glasses.GetComponent<Animator>().Play("palletteSwap");
        }
}
}
