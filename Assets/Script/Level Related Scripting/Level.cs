using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Tube> tubes = new List<Tube>();
    public float counter = 0;
    public int TotalTubeCount;
    public int tubescompleted;
    public Ball ball;
    

    private void Start()
    {
        TotalTubeCount = tubes.Count;
        tubescompleted = TotalTubeCount - 2;
        
    }

    public void OnBall(Ball balls)
    {
        ball = balls;
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
            AudioManager.inst.OnplaySound("Winner Sound");
            UIManager.inst.ChangeUI(ScreenType.GameCompletionScreen);
            
            
            

        }
    }

}
