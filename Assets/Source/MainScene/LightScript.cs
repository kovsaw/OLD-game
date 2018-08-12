using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    public GameObject[] objects;
    private GameObject sun;
    private GameObject moon;
    private Light myLight;
    bool day = true;
    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    void Start () {
        sw.Start();
        myLight = GetComponent<Light>();
        sun = Instantiate (objects[1], objects[1].transform.position, Quaternion.identity) as GameObject;
        Invoke("DayNight", 5f);
    }
	
    void DayNight()
    {
        if (day)
        {
            Destroy(sun);
            moon = Instantiate(objects[0], objects[0].transform.position, Quaternion.identity) as GameObject;
            day = false;
        }
        else
        {
            Destroy(moon);
            sun = Instantiate(objects[1], objects[1].transform.position, Quaternion.identity) as GameObject;
            day = true;
        }
        myLight.enabled = !myLight.enabled;
        Invoke("DayNight", 5f);
    }
    
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space))
        {
            DayNight();
        }

        if (sw.Elapsed.Seconds % 10 == 0)
        {
            DayNight();
        }
	}
}
