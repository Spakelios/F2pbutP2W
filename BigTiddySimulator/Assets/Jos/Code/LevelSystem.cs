using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem
{
    public event EventHandler OnEXPChanged;
    public event EventHandler OnLVLChanged;
    
    private int level;
    private int exp;
    private int expToLevel;

    public LevelSystem()
    {
        level = 0;
        exp = 0;
        expToLevel = 100;
    }

    public void AddExp(int amount)
    {
        exp += amount;

        while (exp >= expToLevel)
        {
            level++;
            exp -= expToLevel;
            if (OnLVLChanged != null) OnLVLChanged(this,EventArgs.Empty);
        }

        if (OnEXPChanged != null) OnEXPChanged(this,EventArgs.Empty);
    }

    public int GetLvlNumber()
    {
        return level;
    }

    public float GetEXPNormalized()
    {
        return (float)exp / expToLevel;
    }

    public int GetEXP()
    {
        return exp;
    }

    public int GetEXPToLevel()
    {
        return expToLevel;
    }
    

}
