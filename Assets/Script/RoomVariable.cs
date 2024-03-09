using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

public class RoomVariable : NetworkBehaviour
{
    public NetworkVariable<int> playerCount = new NetworkVariable<int>(0, NetworkVariableReadPermission.Everyone);
    public NetworkVariable<FixedString32Bytes> myString = new NetworkVariable<FixedString32Bytes>("ID:", NetworkVariableReadPermission.Everyone);
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        if (IsHost)
        {
            playerCount.Value = NetworkManager.Singleton.ConnectedClients.Count;
            myString.Value = HostSingleton.Instance.ID;
            Debug.LogError("connect");
        }
    }

    private void Update()
    {
        if (GameRoom.Instance == null)
            return;
        GameRoom.Instance.txtPlayerCount.text = playerCount.Value.ToString();
        GameRoom.Instance.txtID.text = myString.Value.ToString();
    }
}
