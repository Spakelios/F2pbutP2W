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

    private void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;
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
    }

    public void GoodHit()
    {
        currentScore += ScorePerGoodNote;
        NoteHit();
    }

    public void PerfectHit()
    {
        currentScore += ScorePerPerfectNote;
        NoteHit();
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");

        currentMultiplier = 1;
        multiplierText.text = "Multiplier: " + currentMultiplier;
    }

}