using UnityEngine;
using Bolt;

[BoltGlobalBehaviour]
public class NetworkCallback : Bolt.GlobalEventListener
{
    public override void SceneLoadLocalDone(string scene)
    {
        var spawnPosition = new Vector3(Random.Range(-8, 8), 0, Random.Range(-8, 8));

        BoltNetwork.Instantiate(BoltPrefabs.Cube1, spawnPosition, Quaternion.identity);
    }
}
