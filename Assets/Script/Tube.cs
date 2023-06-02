using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    public List<Ball> balls = new List<Ball>();
    public Transform Topposition;
    private float elepsedtime = 2f;
    private float desiredduration = 4f;
    private float percentagecompleted;
    public Transform[] pos;

    private void OnMouseDown()
    {
       if (TubeManager.inst.ball == null)
        {
            if (balls.Count > 0)
            {

              StartCoroutine(MovetoTopwithLerp());
               
            }

            else
            {
                Debug.Log("Box Empty");
            }

        }
       else
        {
            TubeManager.inst.ball.transform.position = Topposition.position;
            StartCoroutine(MoveToptoTopwithLerp());
         //   moveballin();

              
            
        }
    }
  
    IEnumerator MovetoTopwithLerp()
    {
    while (balls[balls.Count - 1].transform.position != Topposition.position)
        {
            elepsedtime += Time.deltaTime;
            percentagecompleted = elepsedtime / desiredduration;

            balls[balls.Count - 1].transform.position = Vector2.Lerp(balls[balls.Count - 1].transform.position, Topposition.position, percentagecompleted);
                    
            yield return null;
           
        }
        StopCoroutine(MovetoTopwithLerp());
           moveballtop();
        } 

     
    public void moveballtop()
    {  
       TubeManager.inst.ball = balls[balls.Count-1];
       balls.Remove(balls[balls.Count - 1]);      

    }




    IEnumerator MoveToptoTopwithLerp()
    {
        while (TubeManager.inst.ball.transform.position != pos[balls.Count].position)
        {
            elepsedtime += Time.deltaTime;
            percentagecompleted = elepsedtime / desiredduration;
             TubeManager.inst.ball.transform.position = Vector2.Lerp(TubeManager.inst.ball.transform.position, pos[balls.Count].position, percentagecompleted);
             Debug.Log(TubeManager.inst.ball.transform.position = Vector2.Lerp(TubeManager.inst.ball.transform.position, pos[balls.Count].position,percentagecompleted));
             yield return null;

        }

        StopCoroutine(MoveToptoTopwithLerp());
         balls.Add(TubeManager.inst.ball);
         TubeManager.inst.ball = null;
    }






    
    public void  moveballin()
    {
         

        


    }   














}







