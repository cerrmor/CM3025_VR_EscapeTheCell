using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverControl : MonoBehaviour
{
    public Transform leverTop;

    [SerializeField] private float forwardBackwardTilt = 0.0f;
    [SerializeField] private float sideToSideTilt = 0.0f;

    void Update()
    {
        forwardBackwardTilt = leverTop.rotation.eulerAngles.x;
        if (forwardBackwardTilt < 355 && forwardBackwardTilt > 290)
        {
            forwardBackwardTilt = Mathf.Abs(forwardBackwardTilt - 360);
            Debug.Log("Backwards" + forwardBackwardTilt);
        }
        else if (forwardBackwardTilt > 5 && forwardBackwardTilt < 74)
        {
            Debug.Log("forward" + forwardBackwardTilt);
        }

        sideToSideTilt = leverTop.rotation.eulerAngles.z;
        if(sideToSideTilt < 355 && sideToSideTilt > 290)
        {
            sideToSideTilt = Mathf.Abs(sideToSideTilt - 360);
            Debug.Log("right" + sideToSideTilt);
        }
        else if (sideToSideTilt > 5 && sideToSideTilt < 74)
        {
            Debug.Log("left" + sideToSideTilt);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        { 
            transform.LookAt(other.transform.position, transform.up);
        }
    }
}
