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
    private CurrencyManager noteAmount;
    private GameObject theManager;
    public CurrencyManager currencyManager;
    private bool didPull;
    public GameObject commonPool;
    public GameObject uncommonPool;
    public GameObject rarePool;


    private void Start()
    {
        foreach (var instrument in gachaRates)
        {
            total += instrument; //tally the total weight
        }

        funnyButton.onClick.AddListener(TaskOnClick);
        theManager = GameObject.Find("CurrencyManager");
        currencyManager = theManager.GetComponent<CurrencyManager>();
        didPull = false;
        commonPool.SetActive(false);
        uncommonPool.SetActive(false);
        rarePool.SetActive(false);
    }


    void TaskOnClick()
    {


        if (currencyManager.totalNotes >= pullPrice)
        {
            randomDraw = UnityEngine.Random.Range(0, total);
            currencyManager.totalNotes -= pullPrice;

            for (int i = 0; i < gachaRates.Length; i++)

                if (randomDraw <= gachaRates[i])
                {
                    indicators[i].SetActive(true);
                    didPull = true;
                    
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
            Debug.Log("Smells like poor in here lmao");
        }
    }

    void Deactivate()
    {
        commonPool.SetActive(false);
        uncommonPool.SetActive(false);
        rarePool.SetActive(false);
    }
}

