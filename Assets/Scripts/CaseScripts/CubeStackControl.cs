using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStackControl : MonoBehaviour
{
    public GameObject CubePrefab;
    GameObject cube;

    float previousFireRate;
    public int stackCount = 1;



    public void AddStack()
    {
        cube = Instantiate(CubePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        cube.transform.parent = transform;

        for (int i = 0; i < transform.childCount; i++)
        {
            if (i ==0)
            {
                transform.GetChild(i).transform.localPosition += new Vector3(0, 0.05f, 0);
            }
            else
            {
                transform.GetChild(i).transform.localPosition += new Vector3(0, 0.04f, 0);
            }
        }

       

        //for (int i = 1; i < transform.childCount; i++)
        //{
        //    if (transform.GetChild(i).transform.childCount != i + 1)
        //    {
                
        //        cube = Instantiate(CubePrefab,new Vector3(transform.position.x, transform.position.y , transform.position.z) , Quaternion.identity);
        //        break;
        //    }
        //}
    }



    public void IncreaseStackCount()
    {
        stackCount++;
        Debug.Log(stackCount);
    }

    public void DecreaseStackCount()
    {
        stackCount--;
        Debug.Log(stackCount);


    }
  


}
