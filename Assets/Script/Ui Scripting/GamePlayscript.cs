using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamePlayscript : Screens
{
    public Button LevelMenubtn;
    public Button Resetbtn;
    public TMP_Text Levelindicator;
    public LevelData level;
    
   

    public override void OnCanvasEnable()
    {
        base.OnCanvasEnable();
        LevelMenubtn.onClick.AddListener(OnLevelMenu);
        Resetbtn.onClick.AddListener(OnReset);
        
    }

    private void Update()
    {        
        Levelindicator.text = level.GetCurrentLevel().ToString();
    }
    public void OnLevelMenu()
    {
        UIManager.inst.ChangeUI(ScreenType.LevelMenuScreen);
    }

    public void OnReset()
    {
        LevelManager.inst.RemoveLastLevel();
        LevelManager.inst.OnReset();
    }



    public override void OnCanvasDissable()
    {
        base.OnCanvasDissable();
        LevelMenubtn.onClick.RemoveListener(OnLevelMenu);
        Resetbtn.onClick.RemoveListener(OnReset);
       
    }
}
   

