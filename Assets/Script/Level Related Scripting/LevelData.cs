using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData")]
public class LevelData : ScriptableObject
{
    public List<Level> levels = new List<Level>();
    public int currentLevel;

    public void IncreaseCurrentLevel()
    {
        currentLevel++;
    }

    public int GetCurrentLevel()
    {
        return currentLevel + 1;
    }


}

