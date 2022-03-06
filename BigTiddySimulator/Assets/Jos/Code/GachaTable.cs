using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GachaTable : MonoBehaviour
{
    public List<GameObject> indicators;
    public int[] gachaRates = {50, 30, 20}; //common, uncommon, rare

    public int total;
    public int randomDraw;

    private void Start()
    {
        foreach (var instrument in gachaRates)
        {
            total += instrument; //tally the total weight
        }

        randomDraw = UnityEngine.Random.Range(0, total);
        
        for (int i = 0; i < gachaRates.Length; i++)
        {
            if (randomDraw <= gachaRates[i])
            {
                indicators[i].SetActive(true);
                return;
            }

            else
            {
                randomDraw -= gachaRates[i];
            }
        }
    }
}
