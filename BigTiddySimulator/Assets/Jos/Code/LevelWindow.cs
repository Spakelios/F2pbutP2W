using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelWindow : MonoBehaviour
{
    private TMP_Text levelText;
    private Image expBar;
    private LevelSystem levelSystem;
    public Button fiveEXP;
    public Button fiftyEXP;
    public Button fivehundredEXP;
    private LevelSystemAnimated levelSystemAnimated;
    


    private void Awake()
    {
        levelText = transform.Find("Level").GetComponent<TextMeshProUGUI>();
        expBar = transform.Find("EXP Bar").GetComponent<Image>();
        
        fiveEXP.onClick.AddListener(addFive);
        fiftyEXP.onClick.AddListener(addFifty);
        fivehundredEXP.onClick.AddListener(addFiveHundred);
        

    }

    private void SetExperienceBarSize(float expNormalized)
    {
        expBar.fillAmount = expNormalized;
    }

    public void SetLevelNumber(int levelNumber)
    {
        levelText.text = "Level\n" + (levelNumber + 1);
    }

    public void SetLevelSystem(LevelSystem levelSystem)
    {
        this.levelSystem = levelSystem;
    }

    public void SetLevelSystemAnimated(LevelSystemAnimated levelSystemAnimated)
    {
        this.levelSystemAnimated = levelSystemAnimated;
        
        SetLevelNumber((levelSystemAnimated.GetLvlNumber()));
        SetExperienceBarSize(levelSystemAnimated.GetEXPNormalized());

        levelSystemAnimated.OnEXPChanged += LevelSystemAnimated_OnEXPChanged;
        levelSystemAnimated.OnLVLChanged += LevelSystemAnimated_OnLVLChanged;
    }

    private void LevelSystemAnimated_OnLVLChanged(object sender, System.EventArgs e)
    {
        SetLevelNumber((levelSystemAnimated.GetLvlNumber()));
    }
    
    private void LevelSystemAnimated_OnEXPChanged(object sender, System.EventArgs e)
    {
        SetExperienceBarSize((levelSystemAnimated.GetEXPNormalized()));
    }

    void addFive()
    {
        levelSystem.AddExp(5);
    }

    void addFifty()
    {
        levelSystem.AddExp(50);
    }

    void addFiveHundred()
    {
        levelSystem.AddExp(500);
    }
    
    
}
