using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] GameObject character;

     Vector3 offset;

    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - character.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = character.transform.position + offset;
    }
}
