using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
     private Canvas canvas;
     public bool IsActive;
    
     private void Start()
     {
         canvas = GetComponent<Canvas>();        
     }

     public virtual void OnCanvasEnable()
    {
        if (canvas == null)
        {
            canvas = GetComponent<Canvas>();
        }
         canvas.enabled = true;
         IsActive = true;
     }
    
     public virtual void OnCanvasDissable()
     {
         canvas.enabled = false;
         IsActive = false;
     }
    


}
