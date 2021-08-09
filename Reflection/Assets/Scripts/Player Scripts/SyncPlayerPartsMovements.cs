using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncPlayerPartsMovements : MonoBehaviour
{
    public bool isStopped = false; //if 1 part is stopped, both is stopped
    public bool isMainBodyStopped = false;
    public bool isShadowStopped = false;

    private void UpdateSyncStop()
    {
        if(isMainBodyStopped || isShadowStopped) //if either one is stopped, both is stopped
        {
            isStopped = true;
        }
        else
        {
            isStopped = false;
        }
    }

    public void UpdateMainBodyStopStatus(bool isMainBodyStopped)
    {
        this.isMainBodyStopped = isMainBodyStopped;
        UpdateSyncStop();
    }

    public void UpdateShadowStopStatus(bool isShadowStopped)
    {
        this.isShadowStopped = isShadowStopped;
        UpdateSyncStop();
    }

    public bool GetStopStatus()
    {
        return isStopped;
    }
}
