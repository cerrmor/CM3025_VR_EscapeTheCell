using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class openDoor : MonoBehaviour
{
    public Transform handler;
    private Interactable interactable;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
        rb = interactable.transform.parent.parent.gameObject.GetComponent<Rigidbody>();
    }

    private void OnHandHoverBegin(Hand hand)
    {
        hand.ShowGrabHint();
    }

    private void OnHandHoverEnd(Hand hand)
    {
        hand.HideGrabHint();
    }

    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes grabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(gameObject);

        //GRAB THE OBJECT
        if (interactable.attachedToHand == null && grabType != GrabTypes.None)
        {
            hand.AttachObject(gameObject, grabType);
            hand.HoverLock(interactable);
            hand.HideGrabHint();
            rb.freezeRotation = false;
        }
        //RELEASE
        else if (isGrabEnding)
        {
            hand.DetachObject(gameObject);
            hand.HoverUnlock(interactable);
            interactable.transform.position = handler.transform.position;
            interactable.transform.rotation = handler.transform.rotation;
            interactable.transform.localScale = Vector3.one;
            rb.angularVelocity = Vector3.zero;
            rb.velocity = Vector3.zero;
            rb.freezeRotation = true;
            //interactable.transform.parent.parent.gameObject.GetComponent
        }
    }


}
