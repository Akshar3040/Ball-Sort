using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager inst;
    public LevelData leveldata;
     public GameObject CurrentLevelData;
    public  Transform Generatedlevel;

    private void Awake()
    {
        inst = this;
    }

   
    public void ChangeLevel()
    {
        leveldata.IncreaseCurrentLevel();
       
        if (leveldata.currentLevel < leveldata.levels.Count)
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel], Generatedlevel).gameObject;
        }

        else if (leveldata.currentLevel >= leveldata.levels.Count)
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel % leveldata.levels.Count], Generatedlevel).gameObject;
        }
    }

    public void LoadLevel(int levelIndex)
    {           
         leveldata.currentLevel = levelIndex;
        if(leveldata.currentLevel < leveldata.levels.Count)
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel], Generatedlevel).gameObject;
        }

        else if (leveldata.currentLevel >= leveldata.levels.Count)
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel % leveldata.levels.Count], Generatedlevel).gameObject;
        }
    }
    public void RemoveLastLevel()
    {
        Destroy(CurrentLevelData);   
    }   
    public void OnReset()
    {
        CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel], Generatedlevel).gameObject;
    }
}



