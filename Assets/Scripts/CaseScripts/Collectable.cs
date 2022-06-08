using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : CollectableBase
{
    public bool isCollected;
    public int colorValue;

    public override void Collect(Collector collector)
    {
        base.Collect(collector);

        if (!isCollected)
        {
            isCollected = true;
            collector.transform.root.GetComponent<CubeStackControl>().AddStack(gameObject);
        }

    }

  
}
