using UnityEngine;
using UnityEngine.UI;

public class MenuButtonController : MonoBehaviour
{
    private ReturnMenu returnMenu;

    private void Start()
    {
        // Tìm script ReturnMenu trong các con của menuBtn
        returnMenu = GetComponentInChildren<ReturnMenu>();

        Button button = GetComponent<Button>();
        if (button != null && returnMenu != null)
        {
            button.onClick.AddListener(returnMenu.OnMenuButtonClicked);
        }
        else
        {
            Debug.LogWarning("Không tìm thấy Button hoặc ReturnMenu!");
        }
    }
}
