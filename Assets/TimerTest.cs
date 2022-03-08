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
            Debug.Log("START");
        });
    }
}
