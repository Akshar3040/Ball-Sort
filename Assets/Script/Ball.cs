using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public  Vector2 pos;     
    public int clickCount = 0;  
    public bool isballout;
   


    private void Start()
    {
        pos = transform.position;
    }

    private void OnMouseDown()
    {

        Debug.Log("OnMouseDown");

        if (clickCount == 1)
        {
            clickCount = 0;
            isballout = false;
            Tube.inst.balls[Tube.inst.balls.Count - 1].transform.position = pos;
            
        }

        else if(clickCount == 0)
        {
            clickCount = 1;           
            Tube.inst.balls[Tube.inst.balls.Count - 1].transform.position = Tube.inst.Topposition.position;
            
            Debug.Log("Ball Up");
        }

        }

    



}
