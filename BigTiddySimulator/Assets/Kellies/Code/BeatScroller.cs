using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
  public float beatTempo = 2;

   bool hasStarted = true;

  private void Start()
  {
    beatTempo = beatTempo / 60f;
  }

  private void Update()
  {
    if (hasStarted)
    {
      {
        transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
      }
    }
  }
}
