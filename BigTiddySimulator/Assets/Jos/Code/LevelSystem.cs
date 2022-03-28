using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem
{
    public event EventHandler OnEXPChanged;
    public event EventHandler OnLVLChanged;

    private static readonly int[] expPerLVL = new[] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000}; //if we wanna have a set amount of levels & set amount of EXP for each level

    public int level;
    private int exp;


    public LevelSystem()
    {
        level = 0;
        exp = 0;
    }

    public void AddExp(int amount)
    {
        if (!IsMaxLVL()) //level cap
        {
            exp += amount;

            while (!IsMaxLVL() && exp >= GetEXPToLevel(level))
            {
                exp -= GetEXPToLevel(level);
                level++;
                if (OnLVLChanged != null) OnLVLChanged(this, EventArgs.Empty);
            }

            if (OnEXPChanged != null) OnEXPChanged(this, EventArgs.Empty);
        }
    }

    public int GetLvlNumber()
    {
        return level;
    }

    public float GetEXPNormalized()
    {
        if (IsMaxLVL())
        {
            return 1f;
        }
        else
        {
            return (float)exp / GetEXPToLevel(level);
        }
    }

    public int GetEXP()
    {
        return exp;
    }

    public int GetEXPToLevel(int level)
    {
        //return level * 100; //if we wanna go with infinite levels, level 1 = 100exp, level 2 = 200exp, etc.
        
        //level cap:
        if (level < expPerLVL.Length) 
        {
            return expPerLVL[level];
        }
        else
        {
            Debug.LogError("Level invalid: " + level);
            return 100;
        }
    }

    public bool IsMaxLVL() //level cap
    {
        return IsMaxLVL(level);
    }

    public bool IsMaxLVL(int level) //level cap
    {
        return level == expPerLVL.Length - 1;
    }
    

}
