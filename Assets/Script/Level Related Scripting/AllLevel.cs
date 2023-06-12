using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLevel : MonoBehaviour
{
    public LevelData data;
    public LevelData levelcell;
    private void Start()
    {
        for (int i = 0; i < data.levels.Count; i++)
        {
           // levelcell = Instantiate(data.levels,transform.position,transform.rotation);
        }

     }
}
