using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ICollectable
{
    public void Collect(Collector collector)
    {
        throw new System.NotImplementedException();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    PoolingSystem.Instance.InstantiateAPS("cube", transform.position);
    //}
}
