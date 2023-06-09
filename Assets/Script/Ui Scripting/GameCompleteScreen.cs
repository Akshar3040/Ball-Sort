using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameCompleteScreen : Screens
{
    public Button NextButton;


    private void Start()
    {
        NextButton.onClick.AddListener(OnNext);
    }


    public void OnNext()
    {
        UIManager.inst.ChangeUI(ScreenType.GamePlayScreen);
    }
}
