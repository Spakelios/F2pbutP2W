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

    private void SetLevelNumber(int levelNumber)
    {
        levelText.text = "Level\n" + (levelNumber + 1);
    }

    public void SetLevelSystem(LevelSystem levelSystem)
    {
        this.levelSystem = levelSystem;
        
        SetLevelNumber((levelSystem.GetLvlNumber()));
        SetExperienceBarSize(levelSystem.GetEXPNormalized());

        levelSystem.OnEXPChanged += LevelSystem_OnEXPChanged;
        levelSystem.OnLVLChanged += LevelSystem_OnLVLChanged;
    }

    private void LevelSystem_OnLVLChanged(object sender, System.EventArgs e)
    {
        SetLevelNumber((levelSystem.GetLvlNumber()));
    }
    
    private void LevelSystem_OnEXPChanged(object sender, System.EventArgs e)
    {
        SetExperienceBarSize((levelSystem.GetEXPNormalized()));
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
