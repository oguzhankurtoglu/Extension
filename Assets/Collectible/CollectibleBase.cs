using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CollectibleBase : MonoBehaviour,ICollectible
{
    public CollectibleData data;
    public virtual void Collect(Collector collector)
    {
        if (data.particle!=null)
        {
            var effect = Instantiate(data.particle, transform.position + Vector3.up, transform.rotation, transform);
            effect.Play();
        }
    }
}
