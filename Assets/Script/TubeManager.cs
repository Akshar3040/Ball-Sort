using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeManager : MonoBehaviour
{
    public Ball ball;

    public List<Tube> tubes = new List<Tube>();
       
    
    public bool CheckSortingCompletion()
    {
        foreach (Tube tube in tubes)
        {
            if (tube.balls.Count != tube.pos.Length)
            {
                return false;
            }
        }

        Debug.Log("Ball Sorting Completed!");
        return true;
    }


    public void OnBall(Ball balls)
    {
        ball = balls;
    }
    
    public static TubeManager inst;

    private void Awake()
    {
        inst = this;
       
    }



}
