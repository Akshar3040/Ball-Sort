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

    public void OnCanvasEnable()
    {
        canvas.enabled = true;
        IsActive = true;
    }

    public void OnCanvasDissable()
    {
        canvas.enabled = false;
        IsActive = false;
    }


   
}
