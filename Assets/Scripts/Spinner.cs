using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yAngle = 0f;

    void Update()
    {
        float nextRotation = Time.deltaTime * yAngle;
        transform.Rotate(transform.rotation.x, nextRotation, transform.rotation.z);
    }
}
