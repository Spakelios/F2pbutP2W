using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    private int randomise;

    public static GameManager instance;

    public AudioSource theMusic;

    public bool startPLaying;

    public BeatScroller theBS;

    public int currentScore;
    public int ScorePerNote = 100;

    public int ScorePerGoodNote = 125;
    public int ScorePerPerfectNote = 150;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI multiplierText;

    public GameObject resultsScreen;
    public TextMeshProUGUI percentHitText, goodsText, greatsText, perfectsText, missesText, moneyText;
    public float totalHits, goodHits, greatHits, perfectHits, missedHits, percentHit;

    public TextMeshProUGUI drops, drops2, drops3, drops4;


    private void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;
        totalHits = FindObjectsOfType<NoteArea>().Length;
        theMusic.Play();
    }

    private void LateUpdate()
    {
        if (!startPLaying)
        {
            if (Input.anyKeyDown)
            {
                // startPLaying = true;
                theBS.hasStarted = true;
            }
            else if (!theMusic.isPlaying)
            {
                resultsScreen.SetActive(true);
                goodsText.text = " " + goodHits;
                greatsText.text = " " + greatHits;
                perfectsText.text = " " + perfectHits;
                missesText.text = " " + missedHits;
                moneyText.text = " " + ShowCurrency.totalNotes;

                float totalHit = goodHits + greatHits + perfectHits;
                float percentHit = (totalHit / totalHits) * 100f;

                percentHitText.text = percentHit.ToString("F1");

                switch (totalHit)
                {
                    case 20 :

                        ShowCurrency.stings++;
                        ShowCurrency.pucks++;

                        drops.text = "Strings x1";
                        drops2.text = "Pucks x1";

                        break;
                    
                    case 30 :

                        ShowCurrency.brokenKey++;
                        ShowCurrency.screws++;
                        ShowCurrency.stings++;

                        drops.text = "Broken Keys x1";
                        drops2.text = "Screws x1";
                        drops3.text = "Strings x1";

                        break;
                    
                    case 50 :

                        ShowCurrency.brokenKey++;
                        ShowCurrency.screws++;
                        ShowCurrency.brokenKey++;
                        ShowCurrency.stings++;

                        drops.text = "Broken Keys x1";
                        drops2.text = "Screws x1";
                        drops3.text = "Strings x1";
                        drops4.text = "Pucks x1";

                        break;
                    
                    default:
                        ShowCurrency.stings++;
                        ShowCurrency.brokenKey++;

                        drops.text = "Strings x1";
                        drops2.text = "Broken Keys x1";
                        
                        break;
                }
            }
        }
    }




    public void NoteHit()
                {
                    Debug.Log("Hit on Time");

                    if (currentMultiplier - 1 < multiplierThresholds.Length)
                    {
                        multiplierTracker++;

                        if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
                        {
                            multiplierTracker = 0;
                            currentMultiplier++;
                        }
                    }


                    scoreText.text = "Score: " + currentScore;
                    multiplierText.text = "Multiplier: " + currentMultiplier;
                }

                public void NormalHit()
                {
                    currentScore += ScorePerNote;

                    NoteHit();
                    ShowCurrency.totalNotes++;
                    goodHits++;
                }

                public void GoodHit()
                {
                    currentScore += ScorePerGoodNote;
                    NoteHit();
                    greatHits++;
                    ShowCurrency.totalNotes++;

                }

                public void PerfectHit()
                {
                    currentScore += ScorePerPerfectNote;
                    ShowCurrency.totalNotes++;
                    NoteHit();
                    perfectHits++;
                }

                public void NoteMissed()
                {
                    Debug.Log("Missed");

                    missedHits++;
                    currentMultiplier = 1;
                    multiplierText.text = "Multiplier: " + currentMultiplier;
                }

}