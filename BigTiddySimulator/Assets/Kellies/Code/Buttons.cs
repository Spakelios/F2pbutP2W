using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{
    public  GameObject box;
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
     SceneManager.LoadScene("VisualNovelType2");
 }

 public void gaymersGayming()
 {
     SceneManager.LoadScene("Rythm Game");
 }

 public void triangleStratagy()
 {
     SceneManager.LoadScene("homeScreen2");
 }

 public void screenpopup()
 {
     box.SetActive(true);
 }
 
 public void booper()
 {
     SceneManager.LoadScene("Homescreen3");
 }
}
