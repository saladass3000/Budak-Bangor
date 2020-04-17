using Bolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : Bolt.EntityBehaviour<ICostumCubeState>
{
    public float speed = 5.0f;
    public float gravity = -9.0f;
    private CharacterController CC;

    public int characterValues;
    public GameObject myCharacter;
    // Start is called before the first frame update
    public override void Attached()
    {
        state.SetTransforms(state.CubeTransform, transform);
        CC = GetComponent<CharacterController>();
        if (entity.IsOwner)
        {
           CharacterSelect(PlayerInfo.PI.mySelectedChar);
        }
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
        CC.Move(movement);

        if (movement != Vector3.zero)
        {
            transform.position = transform.position + (movement.normalized * speed * BoltNetwork.FrameDeltaTime);
        }
    }

    void CharacterSelect(int whichCharacter)
    {
        myCharacter = BoltNetwork.Instantiate(PlayerInfo.PI.allChar[whichCharacter], new Vector3(0,0,0), Quaternion.identity);
        
    }
}
