using UnityEngine;

namespace Collectible
{
    public class Collector : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            ICollectible collectible = other.GetComponent<ICollectible>();
            collectible?.Collect(this);
        }
    }
}
