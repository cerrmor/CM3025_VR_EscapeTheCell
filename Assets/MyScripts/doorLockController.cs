using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorLockController : MonoBehaviour
{
    private bool lever = false;

    public void setBooltrue()
    {
        lever = true;
    }
    public void setBoolfalse()
    {
        lever = false;
    }
    public bool whatIsState()
    {
        return lever;
    }
}
