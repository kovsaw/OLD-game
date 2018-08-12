using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayScript : MonoBehaviour {
    public GameObject[] objects;

    // Use this for initialization
    void Start () {
        Instantiate(objects[1], objects[1].transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
