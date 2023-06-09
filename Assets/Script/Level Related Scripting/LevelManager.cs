using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager inst;
    public LevelData leveldata;
    private GameObject CurrentLevelData;
    public  Transform Generatedlevel;

    private void Awake()
    {
        inst = this;

    }


    public void ChangeLevel()
    {
        if(leveldata.currentLevel != leveldata.levels.Count)
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel], Generatedlevel).gameObject;
        }
        else
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel % leveldata.levels.Count], Generatedlevel).gameObject;
        }
    }
    

}
