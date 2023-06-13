using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCompletionScreen :Screens
{
    public Button nextbtn; 
    public override void OnCanvasEnable()
    {
        
        base.OnCanvasEnable();
        nextbtn.onClick.AddListener(OnNextButton);
       
    }

    public void OnNextButton()
    {
       
        LevelManager.inst.RemoveLastLevel();
        UIManager.inst.ChangeUI(ScreenType.GamePlayScreen);
        LevelManager.inst.ChangeLevel();

    }

    public override void OnCanvasDissable()
    {
        base.OnCanvasDissable();
        nextbtn.onClick.RemoveListener(OnNextButton);
    }
}  
