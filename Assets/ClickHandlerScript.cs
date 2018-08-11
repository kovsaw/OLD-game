using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickHandlerScript : MonoBehaviour {
	public void handleClick() {
        SceneManager.LoadSceneAsync("HistoryScene", LoadSceneMode.Single);
	}
}
