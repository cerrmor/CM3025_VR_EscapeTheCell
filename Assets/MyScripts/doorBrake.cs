using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBrake : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
}
