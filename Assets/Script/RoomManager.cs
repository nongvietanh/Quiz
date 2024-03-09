using UnityEngine;
using Unity.Netcode;

public class RoomManager : NetworkBehaviour
{
    public int ID;
    [SerializeField] private string nextSceneName;

    public void JoinRoom(int code)
    {
        if (IsClient && code == ID)
        {
            // Join the room
        }
    }

    public void StartGame()
    {
        if (IsServer)
        {
            // Load the next scene for all players
            //NetworkSceneManager.SwitchScene(nextSceneName);
        }
    }
}
