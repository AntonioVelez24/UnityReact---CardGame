using System.Runtime.InteropServices;
using UnityEngine;

public class UnityToReact : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void SendMessageToReact(string message);

    public void SendMessage()
    {
        SendMessageToReact("Mensaje desde Unity - Game2");
    }
    private void Start()
    {
        SendMessage();
    }
}

