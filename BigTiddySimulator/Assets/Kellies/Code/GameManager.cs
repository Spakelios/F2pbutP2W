using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public AudioSource theMusic;

    public bool startPLaying;

    public BeatScroller theBS;

    private void Start()
    {
        instance = this;
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
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");
    }
}
