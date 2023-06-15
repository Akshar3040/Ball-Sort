using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelMenuScreen : Screens
{
    public LevelData data;
    public Transform paranet;
    public LevelCell levelCellprefab;
   
    


    public List<LevelCell> LevelMenu = new List<LevelCell>();

    public override void OnCanvasEnable()
    {
        base.OnCanvasEnable();
        for (int i = 0; i < data.levels.Count; i++)
        {
            LevelCell level = Instantiate(levelCellprefab, paranet);
            int index = i;
            level.SetData(index);
            LevelMenu.Add(level);  
        }
    }

    public override void OnCanvasDissable()
    {
        base.OnCanvasDissable();
        for (int i = 0; i <LevelMenu.Count; i++)
        {
            
            Destroy(LevelMenu[i].gameObject);
           
           
        }
        LevelMenu.Clear();


    }

}
