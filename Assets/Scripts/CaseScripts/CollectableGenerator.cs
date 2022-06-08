using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableGenerator : MonoBehaviour
{
    public float DistanceBetweenCollectables = 0.5f;
    public List<float> XPositions = new List<float>();
    public List<float> ZPos = new List<float>();
    public GameObject cube;
    List<GameObject> allExCubes = new List<GameObject>();
    public List<GameObject> allCubes = new List<GameObject>();
    public bool isFirstEnvironment;
    


    private void Start()
    {
            StartCoroutine(GenerateCo(true));
    }

    public void GenerateCollectables(bool isStarted)
    {
        
        for (float i = -2; i <= 42 ; i+=0.5f)
        {
            int randomXPos = Random.Range(0, 3);
            int randomCube = Random.Range(0, allCubes.Count);
            GameObject obj = Instantiate(allCubes[randomCube], new Vector3(XPositions[randomXPos], 0, i), Quaternion.identity, transform);

            obj.transform.parent = transform;
            obj.transform.localPosition = new Vector3(XPositions[randomXPos], 0, i);

        }
    }

    public IEnumerator GenerateCo(bool isStarted)
    {
        DeleteExCollectables();

        yield return new WaitForSeconds(1);
        GenerateCollectables(isStarted);
    }

    void DeleteExCollectables()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(1).gameObject);
        }

       
    }


}
