using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStackControl : MonoBehaviour
{
    List<GameObject> ObjectsToDestroy = new List<GameObject>();
    GameObject cube;
    bool isOnce = true;
    List<GameObject> Blue = new List<GameObject>();
    List<GameObject> Green = new List<GameObject>();
    List<GameObject> Yellow = new List<GameObject>();
    List<GameObject> Purple = new List<GameObject>();
    List<GameObject> Red = new List<GameObject>();


    int stackCount = 0;

    bool isBlue, isGreen, isPurple, isRed, isYellow;

    public void AddStack(GameObject obj)
    {
        obj.transform.parent = transform;
        obj.transform.localPosition = Vector3.zero;

        Greet(obj);

        for (int i = 0; i < transform.childCount; i++)
        {
            if (i == 0)
            {
                transform.GetChild(i).transform.localPosition = new Vector3(0, 0.04f * (transform.childCount - transform.GetChild(i).GetSiblingIndex() - 1) - 0.02f, 0);

                isOnce = false;
            }
            else
            {
                transform.GetChild(i).transform.localPosition = new Vector3(0, 0.04f * (transform.childCount - transform.GetChild(i).GetSiblingIndex() - 1), 0);
            }
        }
        IncreaseStackCount();
    }

    void Greet(GameObject obj)
    {

        int value = obj.GetComponent<Collectable>().colorValue;
        switch (value)
        {
            case 1:

                Blue.Add(obj);
                ObjectsToDestroy.Add(obj);
                CheckList();
                break;
            case 2:
                Green.Add(obj);

                ObjectsToDestroy.Add(obj);
                CheckList();


                break;
            case 3:
                Purple.Add(obj);

                ObjectsToDestroy.Add(obj);
                CheckList();


                break;
            case 4:
                Red.Add(obj);

                ObjectsToDestroy.Add(obj);
                CheckList();


                break;
            case 5:
                Yellow.Add(obj);

                ObjectsToDestroy.Add(obj);
                CheckList();


                break;
        }
    }

    void SetBoolsToFalse()
    {
        isBlue = false;
        isGreen = false;
        isPurple = false;
        isRed = false;
        isYellow = false;
        ObjectsToDestroy.Clear();
    }

    void CheckList()
    {
        if (Blue.Count >0 && Green.Count >0 && Yellow.Count>0 && Purple.Count>0 &&Red.Count>0)
        {
            DeleteFromList(Blue);
            DeleteFromList(Green);
            DeleteFromList(Yellow);
            DeleteFromList(Purple);
            DeleteFromList(Red);
            StartCoroutine(DeleteStackCo());
            SetBoolsToFalse();
        }
    }

    void DeleteFromList(List<GameObject> obj)
    {
        Destroy(obj[0]);
        obj.RemoveAt(0);
    }

    IEnumerator DeleteStackCo()
    {
        yield return new WaitForSeconds(0.1f);
        DeleteStack();
    }
    public void DeleteStack()
    {
        DecreaseStackCount();
        int DestroyedCubes = 5;
        for (int i = 0; i < transform.childCount; i++)
        {

            if (i == 0)
            {

                transform.GetChild(i).transform.localPosition = new Vector3(0, (0.04f * (transform.childCount - transform.GetChild(i).GetSiblingIndex() - 1)) - 0.02f, 0);
                isOnce = false;
            }
            else
            {
                transform.GetChild(i).transform.localPosition = new Vector3(0, 0.04f * (transform.childCount - transform.GetChild(i).GetSiblingIndex() - 1), 0);
            }
        }
    }

    public void IncreaseStackCount()
    {
        stackCount++;
        Debug.Log(stackCount);
        GetComponentInChildren<Animator>().SetBool("isFloating", true);

    }

    public void DecreaseStackCount()
    {
        stackCount-=5;
        if (stackCount==0)
        {
            GetComponentInChildren<Animator>().SetBool("isFloating", false);
        }

    }



}
