using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    private void Start()
    {
        SceneManager.UnloadSceneAsync("Game");
    }
    public void quit()
    {
        if (!Application.isEditor)
        {
            Application.Quit();
        }
        else
        {
            EditorApplication.isPlaying = false;
        }
    }
    public void startGame()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadSceneAsync("Game");
    }
    public void settingsButton()
    {
        print("Does nothin rn... :'(");
    }
}
