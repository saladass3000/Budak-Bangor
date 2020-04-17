using Bolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerSetup : Bolt.EntityBehaviour<ICostumCubeState>
{
    
    public int characterValues;
    public GameObject myCharacter;

    public override void Attached()
    {
        if (entity.IsOwner)
        {
           CharacterSelect(PlayerInfo.PI.mySelectedChar);
        }
    }

    
    void CharacterSelect(int whichCharacter)
    {
        var spawnPosition = new Vector3(Random.Range(-8, 8), 0, Random.Range(-8, 8));

        myCharacter = BoltNetwork.Instantiate(PlayerInfo.PI.allChar[whichCharacter], spawnPosition, Quaternion.identity);
        
    }
}
