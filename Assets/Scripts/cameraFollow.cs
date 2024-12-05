using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform Target;
    public float speed = 15f;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, Target.rotation, speed * Time.deltaTime);
    }
}
