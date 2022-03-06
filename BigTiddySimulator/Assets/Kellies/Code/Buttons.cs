using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{
    public GameObject panels;
 public void startGame()
 {
     panels.SetActive(false);
 }

 public void endGame()
 {
     
 }
}
