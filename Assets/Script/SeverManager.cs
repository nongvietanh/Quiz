using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeverManager : MonoBehaviour
{
    public static SeverManager Instance;
    [SerializeField] private List<RoomManager> roomManagers = new List<RoomManager>();
    private void Awake()
    {
        Instance = this;
    }

    public void AddRoom(RoomManager roomManager)
    {
        roomManagers.Add(roomManager);
    }

    public bool CheckRoomID(int ID)
    {
        for (int i = 0; i < roomManagers.Count; i++)
        {
            if (roomManagers[i].ID == ID)
                return true;
        }
        return false;
    }
}
