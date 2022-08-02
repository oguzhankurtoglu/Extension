
using UnityEngine;


public class TimerTest : MonoBehaviour
{
    private void Start()
    {
       this.RunAfter(2f,()=>Debug.Log("test"));
    }
}
