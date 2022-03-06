using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Doesitwork : MonoBehaviour
{
 private DialogueSystem dialogue;
 private int index = 0;

 private void Start()
 {
  dialogue = DialogueSystem.instance;
 }

 public string[] s = new string[]
 {
 "nice tits Simp",
 "ty i grew them myself",
 "woah based"
 };

 private void Update()
 {
  if (Input.GetKeyDown(KeyCode.Space))
  {
   if (!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
   {
    if (index >= s.Length)
    {
     return;
    }
    Say(s[index]);
    index++;
   }
  }
 }

 void Say(string s)
 {
  string[] parts = s.Split(':');
  string speech = parts[0];
  string speaker = (parts.Length >= 2 ? parts[1] : "Simp");
  
  dialogue.Say(speech, speaker);
 }
}
