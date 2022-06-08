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

    


    private void Start()
    {
        GenerateCollectables();
    }

    public void GenerateCollectables()
    {
        DeleteExCollectables();
        for (float i = -2; i <= 42 ; i+=0.5f)
        {
            int randomXPos = Random.Range(0, 3);
            int randomCube = Random.Range(0, allCubes.Count);
            //PoolingSystem.Instance.InstantiateAPS("cube" , new Vector3(XPositions[randomXPos], 0,i), Quaternion.identity, transform);
            GameObject obj = Instantiate(allCubes[randomCube], new Vector3(XPositions[randomXPos], 0, i), Quaternion.identity, transform);

            obj.transform.parent = transform;
            obj.transform.localPosition = new Vector3(XPositions[randomXPos], 0, i);


        }
    }

    void DeleteExCollectables()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.layer ==9)
            {
                allExCubes.Add(transform.GetChild(i).gameObject);
            }


        }

        for (int i = 0; i < allExCubes.Count; i++)
        {
            Destroy(allExCubes[0]);
        }
    }


}
