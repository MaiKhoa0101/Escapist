using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using TMPro;
using System.Net;
using System.Net.Sockets;
using System;
using Unity.Netcode.Transports.UTP;

public class UIbuttonNetwork : MonoBehaviour
{
    public UnityTransport transport;
    public TMP_Text address;
    public Button HostButton, ClientButton, ServerButton;

    void Start()
    {
        // Gán sự kiện khi game bắt đầu, tránh gán liên tục trong Update()
        HostButton.onClick.AddListener(StartHost);
        ClientButton.onClick.AddListener(StartClient);
        ServerButton.onClick.AddListener(StartServer);

        // Lấy IP của máy local nếu cần hiển thị
        address.text = GetLocalIPAddress();
    }

    void StartHost()
    {
        transport = NetworkManager.Singleton.GetComponent<UnityTransport>();
        transport.ConnectionData.Address = GetLocalIPAddress(); // Gán địa chỉ trước khi start
        NetworkManager.Singleton.StartHost();
        Debug.Log("Host started at: " + transport.ConnectionData.Address);
    }

    void StartClient()
    {
        if (NetworkManager.Singleton.IsClient || NetworkManager.Singleton.IsHost)
        {
            Debug.LogWarning("Client or Host is already running!");
            return;
        }

        transport = NetworkManager.Singleton.GetComponent<UnityTransport>();
        transport.ConnectionData.Address = "10.0.2.15"; // Thay đổi nếu cần kết nối IP khác
        Debug.Log("Client connecting to: " + transport.ConnectionData.Address);
        NetworkManager.Singleton.StartClient();
    }

    void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        Debug.Log("Server started.");
    }

    string GetLocalIPAddress()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }
}
