using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveAndLoadGame : MonoBehaviour
{
    public LevelData lastlevel;
    public static SaveAndLoadGame inst;    
    public Store store;



    private void Awake()
    {
        inst = this;
    }
    private void Start()
    {
          LoadData();
    }


    public void SaveData()
    {
        store.levelData = lastlevel.currentLevel;
        File.WriteAllText(Application.persistentDataPath + "/data.json", JsonUtility.ToJson(store));
        
    }


   public void LoadData()
   {
       store = JsonUtility.FromJson<Store>(File.ReadAllText(Application.persistentDataPath + "/data.Json"));
    }
}



[System.Serializable]

public class Store
{
    public int levelData;
}
