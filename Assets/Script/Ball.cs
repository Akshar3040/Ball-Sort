using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public  Vector2 pos;
    public GameObject ball;
    public int clickCount = 0;
    public bool isballout;
    public static Ball inst;
    private void Awake()
    {
        inst = this;
    }



    private void Start()
    {
        pos = transform.position;
    }

   public void OnMouseDown()
    
    {
        if (clickCount == 0)
        {
            isballout = true;
            //clickCount = 1;           
            Tube.inst.balls[Tube.inst.balls.Count - 1].transform.position = Tube.inst.Topposition.position;
            Tube.inst.balls.Remove(Tube.inst.balls[Tube.inst.balls.Count - 1]);
            Debug.Log("Ball out");
            TubeManager.inst.OnBall(this);


        }
        
       //if (clickCount == 1)
       //{
       //    clickCount = 0;
       //    isballout = false;
       //    Tube.inst.balls[Tube.inst.balls.Count - 1].transform.position = pos;
       //   
       //
       //}
    }



   public void moveballin()
    {
        TubeManager.inst.ball.transform.position = Tube.inst.Topposition.position;
    }


}
