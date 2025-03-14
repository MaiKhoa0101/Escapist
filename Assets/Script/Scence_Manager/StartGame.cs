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
            Debug.LogWarning("Image kh�ng c� Button component! H�y th�m Button v�o Image.");
        }
    }

    private void OnImageClick()
    {
        Loader.Load(Loader.Scene.MainGameScene);
    }
}
