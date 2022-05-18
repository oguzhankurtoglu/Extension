using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CollectibleType
{
    Coin,
    Item
}
[CreateAssetMenu(fileName = "CollectibleData", menuName = "Collectible")]

public class CollectibleData : ScriptableObject
{
    public ParticleSystem particle;
    public float value;
    public CollectibleType collectibleType;
}
