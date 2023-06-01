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
       if (TubeManager.inst.ball == null)
        {
            if (balls.Count > 0)
            {
                
            }
        }
    }

    public void movetotop()
    {

    }
    

    



}







