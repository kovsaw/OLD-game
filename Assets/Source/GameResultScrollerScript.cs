using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResultScrollerScript : MonoBehaviour
{
    float startYPosition;

    public void Start()
    {
        startYPosition = transform.position.y;
    }

    public void Update()
    {
        float scrollSpeed = 20; // change this parameter to increase or decrease speed of text scrolling 
        Vector3 position = transform.position;
        Vector3 vector3Up = transform.TransformDirection(0, 1, 0);

        position += vector3Up * scrollSpeed * Time.deltaTime;
        transform.position = position;

        if (position.y >= -startYPosition)
        {
            SceneManager.LoadSceneAsync("EndMenuScene", LoadSceneMode.Single);
        }
    }
}
