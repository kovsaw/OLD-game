using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {
    int seconds = 0;
    int mins = 0;
    int hours = 0;

    public float timer;

    void Update()
    {
        if (timer < 99.0f)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 1.0)
        {
            seconds += 1;
            timer = 0;
        }
        if (seconds >= 60)
        {
            mins += 1;
            seconds = 0;
        }
        if (mins >= 60)
        {
            hours += 1;
            mins = 0;
        }
        if (seconds >= 30)
        {
            SceneManager.LoadSceneAsync("WinEndScene", LoadSceneMode.Single);
        }
    }

    private GUIStyle guiStyle = new GUIStyle(); //create a new variable

    void OnGUI()
    {
        guiStyle.normal.textColor = Color.yellow;
        guiStyle.fontSize = 20; //change the font size

        string str1 = seconds.ToString();
        string str2 = mins.ToString();
        string str3 = hours.ToString();

        GUI.Label(new Rect(10, 10, 100, 20), "Time: ", guiStyle);

        GUI.Label(new Rect(10, 30, 100, 20), str3);
        GUI.Label(new Rect(20, 30, 100, 20), ":");
        GUI.Label(new Rect(30, 30, 100, 20), str2);
        GUI.Label(new Rect(40, 30, 100, 20), ":");
        GUI.Label(new Rect(50, 30, 100, 20), str1);
    }
}
