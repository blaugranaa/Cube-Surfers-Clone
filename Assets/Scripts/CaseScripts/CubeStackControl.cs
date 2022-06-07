using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStackControl : MonoBehaviour
{
    public GameObject CubePrefab;
    GameObject cube;

    float previousFireRate;
    public int stackCount = 1;



    public void AddStack( GameObject obj)
    {
        //cube = Instantiate(CubePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        obj.transform.parent = transform;
        obj.transform.localPosition =Vector3.zero;



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

    }
    public void DeleteStack()
    {
        /// stackler silinicek önce 
        /// Silinmiş cube adedini bir değişkende tutuyorum adı DestroyedCubes olsun
        int DestroyedCubes = 0;

        for (int i = 0; i < transform.childCount; i++)
        {
            if (i == 0)
            {
                transform.GetChild(i).transform.localPosition -= new Vector3(0, 0.05f * DestroyedCubes, 0);
            }
            else
            {
                transform.GetChild(i).transform.localPosition = new Vector3(0, (transform.childCount - i) * 0.04f, 0);
            }
        }



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
