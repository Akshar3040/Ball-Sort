using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    public List<Ball> balls = new List<Ball>();
    public Transform Topposition;
    public Transform[] pos;
    [SerializeField] private float moveDurationInSeconds = 1f;
    public bool isSortingCompleted = false;
    [SerializeField] private Level level;
    public ParticleSystem TubeFiledParticle;
    

    

    public void OnMouseDown()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
                if (isSortingCompleted == false)
                {
                    
                      if (level.ball == null)
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
                         if (balls[balls.Count - 1].ballcolortype == level.ball.ballcolortype)
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
    }
    }

    public IEnumerator MovetoTopwithLerp()
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
        AudioManager.inst.OnplaySound("Ball Out Sound");

        level.ball = balls[ballindex];
        balls.Remove(balls[ballindex]);
        


    }


    public IEnumerator moveBallIn()
    {
        var passedTime = 0f;
       
        while (passedTime < moveDurationInSeconds)
        {
            var lerpFactor = passedTime / moveDurationInSeconds;
            var smoothedLerpFactor = Mathf.SmoothStep(0, 1, lerpFactor);
            level.ball.transform.position = Vector2.Lerp(level.ball.transform.position, Topposition.position, smoothedLerpFactor);
            passedTime += Mathf.Min(moveDurationInSeconds - passedTime, Time.deltaTime);
            yield return null;
        }
        

        passedTime = 0;

        while (passedTime < moveDurationInSeconds)
        {
            var lerpFactor = passedTime / moveDurationInSeconds;
            var smoothedLerpFactor = Mathf.SmoothStep(0, 1, lerpFactor);
            level.ball.transform.position = Vector2.Lerp(level.ball.transform.position, pos[balls.Count].position, smoothedLerpFactor);
            passedTime += Mathf.Min(moveDurationInSeconds - passedTime, Time.deltaTime);
            yield return null;
        }
        AudioManager.inst.OnplaySound("Ball In Sound");
        balls.Add(level.ball);
        level.ball = null;       
        CheckSortingCompletion();
        
    }
    public void CheckSortingCompletion()
    {
        if (!isSortingCompleted && balls.Count >= pos.Length)
        {
             bool isSorted = true;
           
           
             Ball.Ballcolortype prevColor = balls[0].ballcolortype;

            for (int i = 1; i < balls.Count; i++)
            {
                if (balls[i].ballcolortype != prevColor)
                {
                    isSorted = false;
                    break;
                }
                
                prevColor = balls[i].ballcolortype;
               
            }
            if (isSorted)
            {
                TubeFiledParticle.Play();
                isSortingCompleted = true;                
                level.TubeFiled();
                           
            }           
            

        }
           
    }

 }
