using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class UIbuttonNetwork : MonoBehaviour
{
    public Button HostButton, ClientButton, ServerButton;
    void Update()
    {
        HostButton.onClick.AddListener(() => { NetworkManager.Singleton.StartHost(); alertClick(); });
        ClientButton.onClick.AddListener(() => { NetworkManager.Singleton.StartClient(); alertClick(); });
        ServerButton.onClick.AddListener(() => { NetworkManager.Singleton.StartServer(); alertClick(); });
    }

    void alertClick()
    {
        Debug.Log("Button Start game is clicked!");
    }
}
