using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCompletionScreen :Screens
{
    public Button nextbtn;
    public List<ParticleSystem> particles = new List<ParticleSystem>();
        
    public override void OnCanvasEnable()
    {       
        base.OnCanvasEnable();
        nextbtn.onClick.AddListener(OnNextButton);

        for (int i = 0; i<particles.Count; i++)
        {
            particles[i].Play();
        }
       
    }

    public void OnNextButton()
    {
        
        SaveAndLoadGame.inst.SaveData();
        LevelManager.inst.RemoveLastLevel();
        UIManager.inst.ChangeUI(ScreenType.GamePlayScreen);
        LevelManager.inst.ChangeLevel();
        
        
       

    }

    public override void OnCanvasDissable()
    {
        base.OnCanvasDissable();
        nextbtn.onClick.RemoveListener(OnNextButton);
        for (int i = 0; i < particles.Count; i++)
        {
            particles[i].Stop();
        }

    }
}  
