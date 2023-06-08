using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeveWinManager : MonoBehaviour
{
    public List<Tube> tubes = new List<Tube>();
    public float counter=0;
    public int TotalTubeCount;
    public int tubescompleted;
    public static LeveWinManager inst;


    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        TotalTubeCount = tubes.Count;
        tubescompleted = TotalTubeCount - 2;
    }


    public void TubeFiled()
    {
        for (int i = 0; i < TotalTubeCount; i++)
        {
            if (tubes[i].isSortingCompleted == true)
            {
                counter++;
                
                break;
            }
            
        }

        if (counter >= tubescompleted)
        {
            print("You Win");

        }
    }

}