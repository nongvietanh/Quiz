using System.Text;
using UnityEngine;
using Unity.Netcode;

public class NetworkString : INetworkSerializable
{
    private string value;

    public void SetValue(string newValue)
    {
        value = newValue;
    }

    public string GetValue()
    {
        return value;
    }

    public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
    {
        throw new System.NotImplementedException();
    }
}
