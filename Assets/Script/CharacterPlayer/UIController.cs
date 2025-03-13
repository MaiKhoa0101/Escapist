using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    private PlayerMoving playerMovingScript;
    public Button leftButton, rightButton, jumpButton;
    private bool isHoldingLeft, isHoldingRight, isHoldingJump;
    public bool isSet = false;

    public void setPlayerMovingScriptVariable(PlayerMoving target)
    {
        playerMovingScript = target;

        if (playerMovingScript != null)
        {
            isSet = true;

            // Su kien nhan
            rightButton.onClick.AddListener(() => { playerMovingScript.GoRight(); alertClick(); });
            leftButton.onClick.AddListener(() => { playerMovingScript.GoLeft(); alertClick(); });
            jumpButton.onClick.AddListener(() => { playerMovingScript.Jump(); alertClick(); });

            // Su kien nhan giu
            AddHoldListener(leftButton, () => isHoldingLeft = true, () => isHoldingLeft = false);
            AddHoldListener(rightButton, () => isHoldingRight = true, () => isHoldingRight = false);
            
            //Su kien nhay ko duoc an giu, neu nhu an giu thi se bay len troi :)))
            //AddHoldListener(jumpButton, () => isHoldingJump = true, () => isHoldingJump = false);
        }
    }

    void Update()
    {
        if (isHoldingLeft) playerMovingScript.GoLeft();
        if (isHoldingRight) playerMovingScript.GoRight();
        if (isHoldingJump) playerMovingScript.Jump();
    }

    void alertClick()
    {
        Debug.Log("Button Clicked!");
    }

    void AddHoldListener(Button button, System.Action onPress, System.Action onRelease)
    {
        EventTrigger trigger = button.gameObject.AddComponent<EventTrigger>();

        EventTrigger.Entry pointerDown = new EventTrigger.Entry();
        pointerDown.eventID = EventTriggerType.PointerDown;
        pointerDown.callback.AddListener((data) => { onPress(); });

        EventTrigger.Entry pointerUp = new EventTrigger.Entry();
        pointerUp.eventID = EventTriggerType.PointerUp;
        pointerUp.callback.AddListener((data) => { onRelease(); });

        trigger.triggers.Add(pointerDown);
        trigger.triggers.Add(pointerUp);
    }
}
