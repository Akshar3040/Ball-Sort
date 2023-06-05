using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    public List<Ball> balls = new List<Ball>();
    public Transform Topposition;   
    public Transform[] pos;
    [SerializeField] private float moveDurationInSeconds = 1f;
   
   


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
                Debug.Log("Box IS Empty");
            }
        }

        else
        {
            if (balls.Count > 0)
            {
                if (balls[balls.Count - 1].ballcolortype == TubeManager.inst.ball.ballcolortype)
                {
                    StartCoroutine(moveBallIn());
                }
            }
            else
            {
                StartCoroutine(moveBallIn());
            }

        }       

    }

    public   IEnumerator MovetoTopwithLerp()
    {
        var passedTime = 0f;
        int ballindex = balls.Count - 1;

        while (passedTime < moveDurationInSeconds)
        {
            var lerpFactor = passedTime / moveDurationInSeconds;
            var smoothedLerpFactor = Mathf.SmoothStep(0, 1, lerpFactor);
            
            balls[ballindex].transform.position = Vector2.Lerp(balls[ballindex].transform.position, Topposition.position, smoothedLerpFactor);
            passedTime += Mathf.Min(moveDurationInSeconds - passedTime, Time.deltaTime);
            yield return null;
           
        }
           
            TubeManager.inst.ball = balls[ballindex];
            balls.Remove(balls[ballindex]);

    } 

   
    public IEnumerator moveBallIn()
    {
        var passedTime = 0f;

        while (passedTime < moveDurationInSeconds)
        {
            var lerpFactor = passedTime / moveDurationInSeconds;
            var smoothedLerpFactor = Mathf.SmoothStep(0, 1, lerpFactor);
            TubeManager.inst.ball.transform.position = Vector2.Lerp(TubeManager.inst.ball.transform.position, Topposition.position, smoothedLerpFactor);
            passedTime += Mathf.Min(moveDurationInSeconds - passedTime, Time.deltaTime);
            yield return null;
           

        }

        passedTime = 0;

        while (passedTime < moveDurationInSeconds)
        {
            var lerpFactor = passedTime / moveDurationInSeconds;
             var smoothedLerpFactor = Mathf.SmoothStep(0, 1, lerpFactor);            
          
            TubeManager.inst.ball.transform.position = Vector2.Lerp(TubeManager.inst.ball.transform.position, pos[balls.Count].position, smoothedLerpFactor);
            passedTime += Mathf.Min(moveDurationInSeconds - passedTime, Time.deltaTime);
            yield return null;
           
   
        }
   
        StopCoroutine(moveBallIn());
         balls.Add(TubeManager.inst.ball);
         TubeManager.inst.ball = null;
        
    }
}