using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    public void OnMenuButtonClicked()
    {
        Loader.Load(Loader.Scene.MenuScene);
    }
}
