using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectable collectable = other.GetComponentInChildren<ICollectable>();
        if (collectable != null)
        {
            collectable.Collect(this);
            //Destroy(other.GetComponent<Collectable>());
            other.GetComponentInChildren<Collectable>().enabled = false;
            if (!other.gameObject.GetComponent<Collector>())
            {
                other.gameObject.AddComponent<Collector>();

            }
        }

       
    }

  
}
