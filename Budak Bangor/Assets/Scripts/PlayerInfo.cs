using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Bolt.EntityBehaviour<ICostumCubeState>
{
    public static PlayerInfo PI;

    public int mySelectedChar;

    public GameObject[] allChar;

    private void OnEnable()
    {
        if(PlayerInfo.PI == null)
        {
            PlayerInfo.PI = this;
        }
        else
        {
            if(PlayerInfo.PI != this)
            {
                Destroy(PlayerInfo.PI.gameObject);
                PlayerInfo.PI = this;
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    public override void Attached()
    {
        if (PlayerPrefs.HasKey("MyCharacter"))
        {
            mySelectedChar = PlayerPrefs.GetInt("MyCharacter");
        }
        else
        {
            mySelectedChar = 0;
            PlayerPrefs.SetInt("Mycharacter", mySelectedChar);
        }
    }

    
}
