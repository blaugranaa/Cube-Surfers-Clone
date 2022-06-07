using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : CollectableBase
{

    public override void Collect(Collector collector)
    {
        base.Collect(collector);
        collector.transform.root.GetComponentInChildren<CubeStackControl>().AddStack();
        //Destroy(gameObject);
        Debug.Log("sdfsdf");
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    PoolingSystem.Instance.InstantiateAPS("cube", transform.position);
    //}
}
