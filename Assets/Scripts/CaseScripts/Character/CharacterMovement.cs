using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float swerveSpeed;
    private void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }

    void Update()
    {
         var ClampPos = transform.position;
            ClampPos.x = Mathf.Clamp(transform.position.x, -0.1506f, 0.1506f);
            transform.position = new Vector3(ClampPos.x, transform.position.y, transform.position.z);
    }


}
