using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager inst;
    public ScreenType InitialScreen;
    private Screens CurrentScreen;
    public List<ScreenClass> CurrentClass = new List<ScreenClass>();


    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        ChangeUI(InitialScreen);
    }

    public void ChangeUI(ScreenType screen)
    {
        if (CurrentScreen != null)
        {
            CurrentScreen.OnCanvasDissable();
            CurrentScreen = null;
        }
        CurrentScreen = CurrentClass.Find(x => x.screenEnum == screen).screen;
        CurrentScreen.OnCanvasEnable();
       
    }

}

[System.Serializable]
public class ScreenClass
{
    public ScreenType screenEnum;
    public Screens screen;
}

public enum ScreenType 
{   
    GamePlayScreen,
    LevelMenuScreen,
    GameCompletionScreen,
}