using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float rotattion;
    private void Update()
    {
        transform.Rotate(Vector2.up, rotattion);
    }


   


}
