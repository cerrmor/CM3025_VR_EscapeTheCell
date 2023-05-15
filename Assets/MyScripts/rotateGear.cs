using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotateGear : MonoBehaviour
{
    public Transform target;
    public Transform thisBody;
    public Rigidbody targetRB;

    public float minAngle = -45.0f;

    public float maxAngle = 45.0f;

    private Vector3 currentRotation;
    private Vector3 currentRotation2;



    void Start()
    {
       
    }

    void FixedUpdate()
    {
        currentRotation = target.transform.localRotation.eulerAngles;
        currentRotation2 = thisBody.transform.localRotation.eulerAngles;
    
        currentRotation.y = Mathf.Clamp(currentRotation.y, minAngle, maxAngle);

        //if(currentRotation.y == maxAngle || currentRotation.y == minAngle) targetRB.freezeRotation = true;
        
        thisBody.transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
