using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    public List<GameObject> balls = new List<GameObject>();
    public Transform Topposition;    
    public static Tube inst;
    public Transform[] pos;


    private void Awake()
    {
        inst = this;
    }


    private void OnMouseDown()
    {
        OnAddball();
        OnRemoveball();
    }



    public void OnAddball()
    {
       
            Debug.Log("BAll Added");

       
           // balls.Add(balls[balls.Count - 1]);
        
    }


    public void OnRemoveball()
    {
       // Debug.Log("Ball Removed");
       // balls.Remove(balls[balls.Count - 1]);
    }


}

