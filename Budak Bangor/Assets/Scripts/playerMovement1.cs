using Bolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement1 : Bolt.EntityBehaviour<ICostumCubeState>
{
    
    public float speed = 6.0f;
    public float gravity = -9.0f;
    private CharacterController charCont;
   
    public override void Attached()
    {
        
        charCont = GetComponent<CharacterController>();
    }

    public override void SimulateOwner()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;

        movement *= BoltNetwork.FrameDeltaTime;
        movement = transform.TransformDirection(movement);
        charCont.Move(movement);
    }
}
