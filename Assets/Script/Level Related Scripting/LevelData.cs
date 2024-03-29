using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData")]
public class LevelData : ScriptableObject
{
    public List<Level> levels = new List<Level>();
    public int currentLevel = 0;


    public void IncreaseCurrentLevel()
    {
        currentLevel++;
    }

    public int GetCurrentLevel()
    {
        if (currentLevel >=10)
        {
            currentLevel = 0;
        }
        return currentLevel +1;
    }

   
}

