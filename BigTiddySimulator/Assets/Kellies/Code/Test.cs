using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Character simp;
    private void Start()
    {
        simp = CharacterManager.instance.GetCharacter("Simp");
    }

    public string[] speech;
    int i = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i < speech.Length)
            {
                simp.say(speech[1]);
            }
            else
            {
                DialogueSystem.instance.close();
            }
        }
    }
}
