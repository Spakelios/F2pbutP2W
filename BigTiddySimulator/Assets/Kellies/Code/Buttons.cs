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
     SceneManager.LoadScene("Rhythm Tutorial");
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
 
 public void levelTwo()
 {
     SceneManager.LoadScene("Level 2");
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
      box2.SetActive(false);
      box3.SetActive(true);
  }

  public void levelOne()
  {
      SceneManager.LoadScene("Level 1");
  }
  public void screenstuffs()
  {
      box.SetActive(false);
      box2.SetActive(true);
      box3.SetActive(true);
  }
}
