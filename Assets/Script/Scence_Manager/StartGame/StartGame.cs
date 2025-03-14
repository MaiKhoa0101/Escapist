using UnityEngine;

public class StartGame: MonoBehaviour
{
    public void OnStartGameButtonClicked()
    {
        Loader.Load(Loader.Scene.MainGameScene);
    }
}
