using UnityEngine;
using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour {
    Stopwatch stopwatch;

    public void Start() {
        stopwatch = new Stopwatch();
        stopwatch.Start();       
    }

    public void Update() {
        TimeSpan span = stopwatch.Elapsed;
        if (span.Seconds == 2) {
            Application.Quit();
        }
    }
}
