using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    public List<Ball> balls = new List<Ball>();
    public Transform Topposition;
    public Transform[] pos;
    [SerializeField] private float moveDurationInSeconds = 1f;
    private bool isSortingCompleted = false;




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

        CheckSortingCompletion();


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

        TubeManager.inst.ball = balls[ballindex];
        balls.Remove(balls[ballindex]);
        CheckSortingCompletion();

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

        
        balls.Add(TubeManager.inst.ball);
        TubeManager.inst.ball = null;
        //CheckSortingCompletion();
        TubeManager.inst.CheckSortingCompletion();
        CheckSortingCompletion();



    }




    private void CheckSortingCompletion()
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
                isSortingCompleted = true;
                Debug.Log("Ball Sorting Completed!");
                // Display win message or perform any other actions
            }
        }
    }
}
