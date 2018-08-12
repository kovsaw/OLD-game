using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayScript : MonoBehaviour {
    public GameObject[] objects;
    
    void Start () {
        Instantiate(objects[1], objects[1].transform.position, Quaternion.identity);
    }
}
