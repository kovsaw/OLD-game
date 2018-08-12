using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickHandlerScript : MonoBehaviour {
	public void StartGameButtonClick() {
        SceneManager.LoadSceneAsync("HistoryScene", LoadSceneMode.Single);
	}

    public void SkipIntroButtonClick()
    {
        SceneManager.LoadSceneAsync("MainGame", LoadSceneMode.Single);
    }
}