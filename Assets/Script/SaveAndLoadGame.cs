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
        store.levelDataStorer = lastlevel.currentLevel;
        File.WriteAllText(Application.persistentDataPath + "/data.json", JsonUtility.ToJson(store));
    }

  

    public void LoadData()
   {
        if (File.Exists(Application.persistentDataPath + "/data.json"))
        {
            

            store = JsonUtility.FromJson<Store>(File.ReadAllText(Application.persistentDataPath + "/data.Json"));
            if (store != null)
            {
                lastlevel.currentLevel = store.levelDataStorer;
            }
            LevelManager.inst.LoadLevel(lastlevel.currentLevel);

        }
        else
        {

            SaveData();
            LevelManager.inst.LoadLevel(lastlevel.currentLevel);
        }
    }


    private void OnApplicationQuit()
    {
        SaveData();
    }

   
}
[System.Serializable]
public class Store
{
    public int levelDataStorer;
}