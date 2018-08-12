using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntityDrop : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Game over!");  // Передаем сообщение в консоль Unity  

        SceneManager.LoadSceneAsync("WinEndScene", LoadSceneMode.Single);
    }
}
