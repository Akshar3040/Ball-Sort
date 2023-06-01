using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public  Vector2 pos;
    public GameObject ball;
    public int clickCount = 0;
    public bool isballout;



    private void Start()
    {
        pos = transform.position;
    }

    private void movetotop()
    { 
       //if (clickCount == 1)
       //{
       //    clickCount = 0;
       //    isballout = false;
       //    Tube.inst.balls[Tube.inst.balls.Count - 1].transform.position = pos;
       //   
       //
       //}

         if(clickCount == 0)
        {
            isballout = true;
            //clickCount = 1;           
            Tube.inst.balls[Tube.inst.balls.Count - 1].transform.position = Tube.inst.Topposition.position;            
            Tube.inst.balls.Remove(Tube.inst.balls[Tube.inst.balls.Count - 1]);
            Debug.Log("Ball out");
           
              
           

        }
    }


}
