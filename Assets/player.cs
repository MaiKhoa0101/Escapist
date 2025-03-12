using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMove playerMove;

    void Start()
    {
        playerMove = GetComponentInChildren<PlayerMove>();
        if (playerMove != null)
        {
            Debug.Log("Tìm thấy PlayerMove!");
        }
    }

    void Update()
    {
        if (playerMove != null)
        {
            // Gọi phương thức di chuyển của PlayerMove
            playerMove.HandleMovement();
        }
    }
}
