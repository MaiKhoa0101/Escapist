using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float moveSpeed = 5f;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = transform.parent;
    }

    public void HandleMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerTransform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Debug.Log("A");
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTransform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Debug.Log("D");
        }
    }
}
