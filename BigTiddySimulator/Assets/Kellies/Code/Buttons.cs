using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{
   
 public void startGame()
 {
     SceneManager.LoadScene("Proto");
 }

 public void gachaTime()
 {
     SceneManager.LoadScene("Gacha Test");
 }

 public void datingTime()
 {
     SceneManager.LoadScene("Visual Novel part");
 }
}
