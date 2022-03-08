using System.Collections;
using UnityEngine;
public class Delay
{
    private bool isDone;
    private IEnumerator coroutine;
    public static Delay RunAfter(float delay, System.Action action)
    {
        var tmp = new Delay();
        tmp.coroutine = Run(tmp,delay,action);
        tmp.Start();
        return tmp;
    }
    private static IEnumerator Run(Delay run,float delay, System.Action action)
    {
        run.isDone = false;
        yield return new WaitForSeconds(delay);
        if(run.coroutine!=null)
            action();
        run.isDone = true;
    }
    
    private void Start()
    {
        //TODO:CoroutineHelper script 
        Test.Instance.StartCoroutine(coroutine);
    }
}
