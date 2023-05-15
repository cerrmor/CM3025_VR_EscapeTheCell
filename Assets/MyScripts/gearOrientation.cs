using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gearOrientation : MonoBehaviour
{
    public Transform target;

    private Vector3 currentRotation;



    void Start()
    {
        currentRotation = target.transform.localRotation.eulerAngles;
        currentRotation.z = -90;
    }

    void Update()
    {
        target.transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
