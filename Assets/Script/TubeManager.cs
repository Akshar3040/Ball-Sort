using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeManager : MonoBehaviour
{
    public static TubeManager inst;
    public Ball ball;
   

    private void Awake()
    {
        inst = this;
       
    }

    public void OnBall(Ball balls)
    {
        ball = balls;
    }

}
