using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader { 
    
    public enum Scene
    {
        MainGameScene,
        Loading,
        MenuScene,
    }

    //lưu callback (hàm sẽ được gọi khi load xong scene loading)
    private static Action onLoaderCallback;

    // Hàm này được gọi để load một scene mới
    public static void Load(Scene scene) {
        // Gán callback: khi màn hình Loading chạy xong, nó sẽ gọi hàm này để load scene chính
        onLoaderCallback = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };

        // Load scene Loading trước
        SceneManager.LoadScene(Scene.Loading.ToString());
    }

    // Hàm này sẽ được gọi từ scene Loading để thực hiện callback (load scene chính)
    public static void LoaderCallback()
    {
        
        if (onLoaderCallback != null) // Kiểm tra xem có hàm callback hay không
        {
            onLoaderCallback(); // Gọi callback để load scene chính
            onLoaderCallback = null;// Reset callback để tránh gọi lại nhiều lần
        }
    }
}
