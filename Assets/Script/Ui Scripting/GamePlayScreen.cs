using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayScreen : Screens
{

    public Button LevelButton;
    public Button ResetButton;


    private void Start()
    {
        LevelButton.onClick.AddListener(OnLevel);
        ResetButton.onClick.AddListener(OnReset);
    }

    public void OnLevel()
    {

    }

    public void OnReset()
    {

    }
}
