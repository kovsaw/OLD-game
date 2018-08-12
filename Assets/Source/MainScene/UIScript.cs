using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {
    public Text counterPeople;
    public long count = 7000000000;
    public GameObject panel; 

    // Use this for initialization
    void Start () {
    }
    public void OnMouseDown()
    {
        count -= 500000000;
    }
    // Update is called once per frame
    void Update () {
        count += 1000000;

        ++count;
        counterPeople.text = count.ToString();

        if (count >= 8000000000)
        {
            SceneManager.LoadSceneAsync("TooManyPeopleLoseScene", LoadSceneMode.Single);

        }
        if (count <= 5000000000)
        {
            Debug.Log("Kill people!");  // Передаем сообщение в консоль Unity  
            Destroy(GameObject.Find("CentrB"));
        }
        if (count >= 8000999999)
        {
            Debug.Log("Kill left!");  // Передаем сообщение в консоль Unity  
            Destroy(GameObject.Find ("Left Turtle"));
        }
        if (count >= 7599999999)
        {
            Debug.Log("Kill right!");  // Передаем сообщение в консоль Unity  
            Destroy(GameObject.Find("Right Turtle"));
        }
        if (count >= 7999999999)
        {
            Debug.Log("Kill center!");  // Передаем сообщение в консоль Unity  
            Destroy(GameObject.Find("Centre Turtles"));
            Destroy(panel);
        }
    }
}
