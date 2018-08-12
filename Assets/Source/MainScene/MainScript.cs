using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {

    public GameObject panel;
    public GameObject cam;
    public bool GameLose = false;
    public float rangeCam = 10f;

    void Update () {
		if (GameLose)
        {
            Destroy(panel);
        }       

        if (Input.GetKey(KeyCode.UpArrow))
            cam.transform.Translate(Vector3.forward * rangeCam);
        if (Input.GetKey(KeyCode.DownArrow))
            cam.transform.Translate(-Vector3.forward * rangeCam);
    }
}
