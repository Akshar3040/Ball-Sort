using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeManager : MonoBehaviour
{
   public Ball ball;

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
