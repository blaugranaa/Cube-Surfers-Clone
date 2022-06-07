using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : CollectableBase
{
    public bool isCollected;
    public override void Collect(Collector collector)
    {
        base.Collect(collector);
        if (!isCollected)
        {
            collector.transform.root.GetComponent<CubeStackControl>().AddStack(gameObject);
            //Destroy(gameObject);
            isCollected = true;
            Debug.Log("sdfsdf");
        }
       
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Cube cube = other.GetComponent<Cube>();
    //    if (cube != null && !isCollected && cube.isCollected)
    //    {
    //        isCollected = true;
    //        transform.root.GetComponent<CubeStackControl>().AddStack(gameObject);
    //    }

    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    PoolingSystem.Instance.InstantiateAPS("cube", transform.position);
    //}
}
