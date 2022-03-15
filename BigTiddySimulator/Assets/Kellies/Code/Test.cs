using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Character portrait;
    private void Start()
    {
        portrait = CharacterManager.instance.GetCharacter("Tri-Chan");
    }

    public string[] speech;
    int i = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i < speech.Length)
            {
                portrait.say(speech[1]);
            }
            else
            {
                DialogueSystem.instance.close();
            }
        }
    }
}
