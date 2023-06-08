using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBaseClass : MonoBehaviour
{
    private Canvas canvas;


    private void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    public void OnEnable()
    {
        canvas.enabled = true;
    }

    public void OnDisable()
    {
        canvas.enabled = false;
    }

    public enum UIScreenList
    {
        GamePlayCanvas,
        GameWinLoadNextLevepopoup,
    }

}
