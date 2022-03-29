using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{
    public  GameObject box;
    public  GameObject box2;
    public  GameObject box3;
 public void startGame()
 {
     SceneManager.LoadScene("Rhythm Game 2");
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
 
 public void notutorial()
 {
     SceneManager.LoadScene("Rythm game but not tutorial");
 }

 public void screenpopback()
 {
     box.SetActive(false);
 }
 
  public void screenback()
  {
      box2.SetActive(false);
  }

  public void screen()
  {
      box2.SetActive(true);
  }


  public void screenstuff()
  {
      box.SetActive(false);
      box2.SetActive(true);
  }
  
}
