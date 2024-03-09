using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class JoinRoom : MonoBehaviour
{
    [SerializeField] private GameObject objPopupBoxEnterID;
    public void Join()
    {
        NetworkManager.Singleton.StartClient();
    }

    public void JoinID(int ID)
    {

    }
}
