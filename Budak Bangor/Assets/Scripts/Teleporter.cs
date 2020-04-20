using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : Bolt.EntityBehaviour<ICostumCubeState>
{
    public GameObject ui;
    public GameObject obj;
    public Transform tpLoc;

    public override void Attached()
    {
        ui.SetActive(false);
        state.SetTransforms(state.CubeTransform, transform);
    }

    
    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Guru") && Input.GetKeyDown(KeyCode.E))
        {
            obj.transform.position = tpLoc.transform.position;
        }

    }

    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
