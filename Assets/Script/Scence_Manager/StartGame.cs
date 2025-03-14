using UnityEngine;
using UnityEngine.UI;

public class StartGame: MonoBehaviour
{
    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnImageClick);
        }
        else
        {
            Debug.LogWarning("Image không có Button component! Hãy thêm Button vào Image.");
        }
    }

    private void OnImageClick()
    {
        Loader.Load(Loader.Scene.MainGameScene);
    }
}
