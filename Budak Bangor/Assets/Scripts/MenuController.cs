using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : Bolt.GlobalEventListener
{
   public void OnClickCharacterPick(int whichCharacter)
    {
        if(PlayerInfo.PI != null)
        {
            PlayerInfo.PI.mySelectedChar = whichCharacter;
            PlayerPrefs.SetInt("MyCharacter", whichCharacter);
        }
    }
}
