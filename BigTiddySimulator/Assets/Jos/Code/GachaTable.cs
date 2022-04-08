using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GachaTable : MonoBehaviour
{
    public List<GameObject> indicators;
    public int[] gachaRates = {10, 10, 10, 10, 10, 10, 10, 10, 10, 5, 5};
    //public int[] gachaRates = {50, 40, 10};//common, uncommon, rare


    public int total;
    public int randomDraw;
    public Button funnyButton;
    public int pullPrice;
    private GameObject theManager;
    public CurrencyManager currencyManager;
    
    //common pool
    public GameObject clarinet;
    public GameObject cymbals;
    public GameObject trombone;
    public GameObject harp;
    public GameObject flute;
    //public GameObject commonPool;
    
    //rare pool
    public GameObject piano;
    public GameObject doubleBass;
    public GameObject frenchHorn;
    public GameObject organ;
    //public GameObject rarePool;
    
    //ultra rare pool
    public GameObject violin;
    public GameObject xylophone;
    //public GameObject ultraPool;
    
    public GameObject poorReminder;


    private void Start()
    {
        foreach (var instrument in gachaRates)
        {
            total += instrument; //tally the total weight
        }

        funnyButton.onClick.AddListener(TaskOnClick);
        theManager = GameObject.Find("CurrencyManager");
        currencyManager = theManager.GetComponent<CurrencyManager>();
        
        
        clarinet.SetActive(false);
        cymbals.SetActive(false);
        trombone.SetActive(false);
        harp.SetActive(false);
        flute.SetActive(false);
        
        piano.SetActive(false);
        doubleBass.SetActive(false);
        frenchHorn.SetActive(false);
        organ.SetActive(false);
        
        violin.SetActive(false);
        xylophone.SetActive(false);
        
        poorReminder.SetActive(false);
    }


    void TaskOnClick()
    {


        if (currencyManager.totalNotes >= pullPrice)
        {
            randomDraw = UnityEngine.Random.Range(0, total);
            currencyManager.totalNotes -= pullPrice;
            ShowCurrency.totalNotes -= pullPrice;

            for (int i = 0; i < gachaRates.Length; i++)

                if (randomDraw <= gachaRates[i])
                {
                    indicators[i].SetActive(true);

                    if (clarinet.activeInHierarchy || cymbals.activeInHierarchy || trombone.activeInHierarchy || harp.activeInHierarchy || flute.activeInHierarchy || piano.activeInHierarchy || doubleBass.activeInHierarchy || frenchHorn.activeInHierarchy || organ.activeInHierarchy || violin.activeInHierarchy || xylophone.activeInHierarchy)
                    {
                        Invoke(nameof(Deactivate), 1.0f);
                    }

                    if (clarinet.activeInHierarchy)
                    {
                        ShowCurrency.glasses += 1;
                    }
                    else if (cymbals.activeInHierarchy) 
                    {
                        ShowCurrency.wall += 1;
                    }
                    else if (organ.activeInHierarchy) 
                    {
                        ShowCurrency.ponytail += 1;
                    }   
                    else if (trombone.activeInHierarchy) 
                    {
                        ShowCurrency.bowl += 1;
                    }
                    else if (harp.activeInHierarchy) 
                    {
                        ShowCurrency.harp += 1;
                    }
                    else if (flute.activeInHierarchy) 
                    {
                        ShowCurrency.flute += 1;
                    }
                    else if (piano.activeInHierarchy) 
                    {
                        ShowCurrency.piano += 1;
                    }
                    else if (doubleBass.activeInHierarchy) 
                    {
                        ShowCurrency.bass += 1;
                    }
                    else if (frenchHorn.activeInHierarchy) 
                    {
                        ShowCurrency.fhorn += 1;
                    }
                    else if (violin.activeInHierarchy) 
                    {
                        ShowCurrency.violin += 1;
                    }
                    else if (xylophone.activeInHierarchy) 
                    {
                        ShowCurrency.himbo += 1;
                    }
                    
                    return;
                    
                    
                }

                else
                {
                    randomDraw -= gachaRates[i];
                }
        }

        else
        {
            poorReminder.SetActive(true);

            if (poorReminder.activeInHierarchy)
            {
                Invoke(nameof(Deactivate), 1.0f);
            }
        }
    }

    void Deactivate()
    {
        clarinet.SetActive(false);
        cymbals.SetActive(false);
        trombone.SetActive(false);
        harp.SetActive(false);
        flute.SetActive(false);
        
        piano.SetActive(false);
        doubleBass.SetActive(false);
        frenchHorn.SetActive(false);
        organ.SetActive(false);
        
        violin.SetActive(false);
        xylophone.SetActive(false);
    }
}

