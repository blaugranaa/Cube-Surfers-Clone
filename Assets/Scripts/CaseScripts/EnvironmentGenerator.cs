using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnvironmentGenerator : MonoBehaviour
{
    CollectableGenerator collectableGenerator;

    public List<GameObject> Environment = new List<GameObject>();
    float offset = 45;
    GameObject movedEnvironment;

    public void MoveEnvironment()
    {
        movedEnvironment = Environment[0];
        Environment.Remove(movedEnvironment);
        float newZ = Environment[Environment.Count - 1].transform.position.z + offset;
        movedEnvironment.transform.position = new Vector3(movedEnvironment.transform.position.x, 0, newZ);
        Environment.Add(movedEnvironment);
        collectableGenerator = movedEnvironment.GetComponent<CollectableGenerator>();
        StartCoroutine(collectableGenerator.GenerateCo(false));
    }

 
}
