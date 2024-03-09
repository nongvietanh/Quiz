using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoom : MonoBehaviour
{
    public int ID_Room;
    public void CreateID()
    {
        ID_Room = Random.Range(100000,1000000);
    }
}
