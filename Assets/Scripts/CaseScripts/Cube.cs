using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        PoolingSystem.Instance.InstantiateAPS("cube", transform.position);
    }
}
