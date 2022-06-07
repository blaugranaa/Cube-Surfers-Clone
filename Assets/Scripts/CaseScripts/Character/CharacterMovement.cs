using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }
}
