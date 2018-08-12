using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickHandlerScript : MonoBehaviour
{
    public void ShowHistory() {
        SceneManager.LoadSceneAsync("HistoryScene", LoadSceneMode.Single);
    }

    public void StartMainGame() {
        SceneManager.LoadSceneAsync("MainGame", LoadSceneMode.Single);
    }

    public void QuitGame() {
        SceneManager.LoadSceneAsync("GoodbyeScene", LoadSceneMode.Single);
    }

    public void SkipGameResultScene() {
        SceneManager.LoadSceneAsync("EndMenuScene", LoadSceneMode.Single);
    }
}
