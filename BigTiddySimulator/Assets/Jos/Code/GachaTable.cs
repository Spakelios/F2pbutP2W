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
    public int[] gachaRates = {50, 30, 20}; //common, uncommon, rare

    public int total;
    public int randomDraw;
    public Button funnyButton;
    public int pullPrice;
    private GameObject theManager;
    public CurrencyManager currencyManager;
    public GameObject commonPool;
    public GameObject uncommonPool;
    public GameObject rarePool;
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
        commonPool.SetActive(false);
        uncommonPool.SetActive(false);
        rarePool.SetActive(false);
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

                    if (commonPool.activeInHierarchy || uncommonPool.activeInHierarchy || rarePool.activeInHierarchy)
                    {
                        Invoke(nameof(Deactivate), 1.0f);
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
        commonPool.SetActive(false);
        uncommonPool.SetActive(false);
        rarePool.SetActive(false);
        poorReminder.SetActive(false);
    }
}

