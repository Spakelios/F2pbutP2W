using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteArea : MonoBehaviour
{
    public bool canBePRessed;
    public KeyCode keyToPress;

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePRessed)
            {
                gameObject.SetActive(false);
                GameManager.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Activator"))
        {
            canBePRessed = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Activator"))
        {
            canBePRessed = false;
            
            GameManager.instance.NoteMissed();
        }
    }
}
