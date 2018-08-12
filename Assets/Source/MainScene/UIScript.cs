using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UIScript : MonoBehaviour {
    public Text counterPeople;
    public Int64 count = 7000000000;
    public GameObject panel;
    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
    System.Diagnostics.Stopwatch stopwatchForCountingTimeT = new System.Diagnostics.Stopwatch();

    public void Start()
    {
        counterPeople.text = count.ToString();
    }

    public void OnMouseDown()
    {
        count -= 500000000;
        var buf = Convert.ToInt64(counterPeople.text) - 500000000;
        counterPeople.text = buf.ToString();
    }

    void Update () {
        count = Convert.ToInt64(counterPeople.text);
        count += 1000000;

        if (count <= 0)
        {
            SceneManager.LoadSceneAsync("AllPeopleDiedLoseScene", LoadSceneMode.Single);
        }        

        if (count >= 7330000000)
        {
            GameObject buffer;
            if ((buffer = GameObject.Find("LeftTurtle")) != null)
            {
                Debug.Log("Left turtle is dead!");  // Передаем сообщение в консоль Unity  
                Destroy(buffer);
            }
        }

        if (count >= 7660000000)
        {
            GameObject buffer;
            if ((buffer = GameObject.Find("RightTurtle")) != null)
            {
                Debug.Log("Right turtle is dead!");  // Передаем сообщение в консоль Unity  
                Destroy(buffer);
            }            
        }

        if (count >= 8000000000)
        {
            GameObject buffer;
            if ((buffer = GameObject.Find("PeopleCount")) != null)
            {
                Destroy(buffer);
            }

            Debug.Log("Lol.. Watch.");  // Передаем сообщение в консоль Unity  
            
            if ((buffer = GameObject.Find("CenterTurtle")) != null)
            {
                Debug.Log("Centre turtle is dead!");  // Передаем сообщение в консоль Unity  
                Destroy(buffer);
            }

            if ((buffer = GameObject.Find("MainBuilding")) != null)
            {
                Destroy(buffer);
            }

            if ((buffer = GameObject.Find("Panel")) != null)
            {
                Destroy(buffer);
            }

            if ((buffer = GameObject.Find("CheckGOPanel")) != null)
            {
                Destroy(buffer);
            }

            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }

            var timeSpan = stopwatch.Elapsed;
            if (timeSpan.Seconds == 2)
            {
                List<String> list = new List<String>
                {
                    "TooManyPeopleLoseScene",
                    "EarthDiedLoseScene",
                    "NotEnoughActivityLoseScene"
                };

                System.Random random = new System.Random();
                SceneManager.LoadSceneAsync(list.ElementAt(random.Next(0, 3)), LoadSceneMode.Single);
            }
        }

        if (count > 0)
        {
            counterPeople.text = count.ToString();
        }
    }
}
