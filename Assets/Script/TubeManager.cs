using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeManager : MonoBehaviour
{
  

   public Ball ball;

    public static TubeManager inst;

    private void Awake()
    {
        inst = this;
    }



}
