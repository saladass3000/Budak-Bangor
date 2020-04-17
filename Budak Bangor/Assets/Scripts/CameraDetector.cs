using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetector : Bolt.EntityBehaviour<ICostumCubeState>
{
    public Camera entityCamera;
    
    public override void SimulateOwner()
    {
        if (entity.IsOwner && entityCamera.gameObject.activeInHierarchy == false)
        {
            entityCamera.gameObject.SetActive(true);
        }
    }
}
