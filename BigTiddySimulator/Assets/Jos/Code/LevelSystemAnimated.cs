using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystemAnimated
{
    public event EventHandler OnEXPChanged;
    public event EventHandler OnLVLChanged;
    private LevelSystem levelSystem;
    private bool isAnimating;

    public int level;
    private int exp;

    private float updateTimer;
    private float updateTimerMax;

    public LevelSystemAnimated(LevelSystem levelSystem)
    {
        SetLevelSystem(levelSystem);
        UpdateCaller.OnUpdate += Update;
        updateTimerMax = .016f;
    }

    ~LevelSystemAnimated()
    {
        UpdateCaller.OnUpdate -= Update;
    }

    public void SetLevelSystem(LevelSystem levelSystem)
    {
        this.levelSystem = levelSystem;

        level = levelSystem.GetLvlNumber();
        exp = levelSystem.GetEXP();

        levelSystem.OnEXPChanged += LevelSystem_OnEXPChanged;
        levelSystem.OnLVLChanged += LevelSystem_OnLVLChanged;
    }

    private void LevelSystem_OnLVLChanged(object sender, EventArgs e)
    {
        isAnimating = true;
    }

    private void LevelSystem_OnEXPChanged(object sender, EventArgs e)
    {
        isAnimating = true;
    }

    private void Update()
    {
        if (isAnimating)
        {
            updateTimer += Time.deltaTime;

            if (updateTimer > updateTimerMax)
            {
                updateTimer -= updateTimerMax;
                
                if (level < levelSystem.GetLvlNumber())
                {
                    AddEXP();
                }

                else
                {
                    if (exp < levelSystem.GetEXP())
                    {
                        AddEXP();
                    }

                    else
                    {
                        isAnimating = false;
                    }
                }
            }
        }
    }

    private void AddEXP()
    {
        exp++;
        
        if (exp >= levelSystem.GetEXPToLevel(level))
        {
            level++;
            exp = 0;
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
        if (levelSystem.IsMaxLVL(level))
        {
            return 1f;
        }
        else
        {
            return (float)exp / levelSystem.GetEXPToLevel(level);
        }
    }

}
