using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Services.Relay;
using Unity.Netcode.Transports.UTP;
using Unity.Networking.Transport.Relay;
using Unity.Services.Relay.Models;
using System;

public class GameRoom : MonoBehaviour
{
    public TextMeshProUGUI txtID;
    [SerializeField] private Button btnStart;
    public TextMeshProUGUI txtPlayerCount;

    public static GameRoom Instance;
    private void Awake()
    {
        Instance = this;
        /*if (IsHost)
        txtID.text = HostSingleton.Instance.ID;*/
    }
}
