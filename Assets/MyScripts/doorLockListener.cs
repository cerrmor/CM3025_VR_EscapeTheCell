using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorLockListener : MonoBehaviour
{
    public bool lever1Solution = false;
    public bool lever2Solution = false;
    public bool lever3Solution = false;

    public doorLockController dlc1;
    public doorLockController dlc2;
    public doorLockController dlc3;

    private bool lever1;
    private bool lever2;
    private bool lever3;

    public Collider doorlock;
    public doorUnlockSound sound;
    private bool soundPlayed = false;
    void Start()
    {
        doorlock.enabled = false;
    }

    void FixedUpdate()
    {
        lever1 = dlc1.whatIsState();
        lever2 = dlc2.whatIsState();
        lever3 = dlc3.whatIsState();

        if (lever1 == lever1Solution && lever2 == lever2Solution && lever3 == lever3Solution)
        {
            doorlock.enabled = true;
            if (!soundPlayed)
            {
                sound.playsound();
                soundPlayed = true;
            }
        }
        else
        {
            doorlock.enabled = false;
            if(soundPlayed)
            {
                soundPlayed = false;
            }
        }
    }
}
