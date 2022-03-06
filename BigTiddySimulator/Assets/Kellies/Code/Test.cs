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
}
