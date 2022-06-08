using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectable collectable = other.GetComponentInChildren<ICollectable>();
        if (collectable != null)
        {
            collectable.Collect(this);
        }

       
    }

  
}
