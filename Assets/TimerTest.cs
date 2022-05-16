using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimerTest : MonoBehaviour
{
    private void Start()
    {
        Delay.RunAfter(2f, () =>
        {
            Debug.Log("started");
        } );
    }

    private void Movement()
    {
        Delay.RunAfter(1f,()=> Debug.Log("moved"));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Movement();
        }
    }
}
