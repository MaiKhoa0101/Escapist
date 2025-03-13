using UnityEngine;
using Unity.Netcode;

public class PlayerMoving : NetworkBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rigidbodyPlayer;

    private void Start()
    {
        rigidbodyPlayer = GetComponentInParent<Rigidbody2D>();
        moveSpeed = 1f;
        if (!IsOwner)
        {
            enabled = false; // Disable for other players
        }
    }

    public void GoLeft()
    {
        rigidbodyPlayer.linearVelocity = new Vector2(-2 * moveSpeed, rigidbodyPlayer.linearVelocity.y);
    }
    public void GoRight()
    {
        rigidbodyPlayer.linearVelocity = new Vector2(2 * moveSpeed, rigidbodyPlayer.linearVelocity.y);
    }
    public void Jump()
    {
        rigidbodyPlayer.linearVelocity = new Vector2(rigidbodyPlayer.linearVelocity.x, 5 * moveSpeed);
    }
}
