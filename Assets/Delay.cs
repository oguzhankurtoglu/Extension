using System.Collections;
using UnityEngine;
public class Delay
{
    private IEnumerator _coroutine;
    public static Delay RunAfter(float duration, System.Action action)
    {
        var tmp = new Delay();
        tmp._coroutine = Run(tmp,duration,action);
        tmp.StartRoutine();
        return tmp;
    }
    private static IEnumerator Run(Delay run,float duration, System.Action action)
    {
        yield return new WaitForSeconds(duration);
        if(run._coroutine!=null)
            action();
    }
    
    private void StartRoutine()
    {
        //TODO:CoroutineHelper script 
        Test.Instance.StartCoroutine(_coroutine);
    }
}
