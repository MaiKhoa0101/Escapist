using UnityEngine;
using UnityEngine.UI;

public class startGameBtnController : MonoBehaviour
{
    private StartGame startGame;

    private void Start()
    {
        startGame = GetComponentInChildren<StartGame>();

        Button button = GetComponent<Button>();
        if (button != null && startGame != null)
        {
            button.onClick.AddListener(startGame.OnStartGameButtonClicked);
        }
        else
        {
            Debug.LogWarning("Không tìm thấy Button hoặc StartGame!");
        }
    }

}
