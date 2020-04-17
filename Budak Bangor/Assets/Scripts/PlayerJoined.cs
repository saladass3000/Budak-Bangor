using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoined : Bolt.EntityBehaviour<ICostumCubeState>

{
    private string username;

    public override void Attached()
    {
        var evnt = PlayerJoinedEvent.Create();
        evnt.Message = "Hello There";
        evnt.Send();
    }

   
}
