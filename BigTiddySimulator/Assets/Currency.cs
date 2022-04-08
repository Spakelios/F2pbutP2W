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
    public Animator ponytail, glasses,wall, flute, fhorn , violin , bowl , piano , bass, himbo , harp;
    public Button viola;
    public Button himbos;

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
        
        if (ShowCurrency.ponytail >= 2)
        {
            ponytail.GetComponent<Animator>().Play("organSwap");
        }
        if (ShowCurrency.wall >= 2)
        {
            wall.GetComponent<Animator>().Play("trumpetSwap");
        } 
        if (ShowCurrency.glasses >= 2)
        {
            glasses.GetComponent<Animator>().Play("palletteSwap");
        }
         if (ShowCurrency.harp >= 2)
        {
            harp.GetComponent<Animator>().Play("harp");
        }
         if (ShowCurrency.bass >= 2)
        {
            bass.GetComponent<Animator>().Play("bass");
        }
         if (ShowCurrency.flute >= 2)
        {
            flute.GetComponent<Animator>().Play("flute");
        }
         if (ShowCurrency.himbo >= 2)
        {
            himbo.GetComponent<Animator>().Play("himbo");
            himbos.interactable = true;
        }
         else
         {
             himbos.interactable = false;
         }
         if (ShowCurrency.fhorn >= 2)
        {
            fhorn.GetComponent<Animator>().Play("fhorn");
        }
         if (ShowCurrency.violin >= 2)
        {
            violin.GetComponent<Animator>().Play("violin");
            viola.interactable = true;
        }
         else
         {
             viola.interactable = false;
         }
         if (ShowCurrency.bowl >= 2)
        {
            bowl.GetComponent<Animator>().Play("bowl4");
        }
         if (ShowCurrency.piano >= 2)
        {
            piano.GetComponent<Animator>().Play("piano");
        }
    }
}

