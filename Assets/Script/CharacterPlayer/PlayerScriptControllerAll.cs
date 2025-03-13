using UnityEngine;

public class PlayerScriptControllerAll : MonoBehaviour
{
    [SerializeField]
    public PlayerMoving playerMoving;
    public UIController controller;
    private void Start()
    {

        playerMoving = GetComponentInChildren<PlayerMoving>();
        controller = GetComponentInChildren<UIController>();
        if (controller == null)
        {
            Debug.Log("Ko tim thay UIcontroller");
        }
        if (playerMoving == null)
        {
            Debug.Log("Ko tim thay Playermoving");
        }
        else
        {
            controller.setPlayerMovingScriptVariable(playerMoving);
        }
    }

}
