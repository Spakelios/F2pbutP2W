using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public AudioSource theMusic;

    public bool startPLaying = true;

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

    public float totalNotes;
    public float normalHits;
    public float goodHits;
    public float perfectHits;
    public float missedHits;

    public GameObject resultsScreen;
    public TextMeshProUGUI percentageText, goodsText, greatsText, perfectsText, missedsText;

    private void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 2;

        totalNotes = FindObjectsOfType<NoteArea>().Length;
    }

    private void Update()
    {
        if (!startPLaying)
        {
            if (Input.anyKeyDown)
            {
                startPLaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
            else
            {
                if (!theMusic.isPlaying && !resultsScreen.activeInHierarchy)
                {
                    resultsScreen.SetActive(true);
                   

                    goodsText.text = normalHits.ToString();
                    greatsText.text = goodHits.ToString();
                    perfectsText.text = perfectHits.ToString();
                    missedsText.text = missedHits.ToString();

                    float totalHit = normalHits + goodHits + perfectHits;
                    float percentHit = (totalHit / totalNotes) * 100f;

                    percentageText.text = percentHit.ToString("F1") + "%";

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

            //currentScore += ScorePerNote * currentMultiplier;
            scoreText.text = "Score: " + currentScore;
            multiplierText.text = "Multiplier: " + currentMultiplier;
        }
    

    public void NormalHit()
        {
            normalHits++;
            currentScore += ScorePerNote;
            NoteHit();

        }

        public void GoodHit()
        {
            goodHits++;
            currentScore += ScorePerGoodNote;
            NoteHit();
        }

        public void PerfectHit()
        {
            perfectHits++;
            currentScore += ScorePerPerfectNote;
            NoteHit();
        }

        public void NoteMissed()
        {
            Debug.Log("Missed");

            missedHits++;

            currentMultiplier = 1;
            multiplierTracker = 0;
            multiplierText.text = "Multiplier: " + currentMultiplier;
        }
    }
