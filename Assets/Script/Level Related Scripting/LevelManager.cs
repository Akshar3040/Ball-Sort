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

    private void Start()
    {
        LoadLevel(1);
    }


    public void ChangeLevel()
    {
        leveldata.IncreaseCurrentLevel();
        if (leveldata.currentLevel != leveldata.levels.Count)
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel], Generatedlevel).gameObject;
        }
        else
        {
            CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel % leveldata.levels.Count], Generatedlevel).gameObject;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        leveldata.currentLevel = levelIndex - 1;
        CurrentLevelData = Instantiate(leveldata.levels[leveldata.currentLevel], Generatedlevel).gameObject;
        
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
