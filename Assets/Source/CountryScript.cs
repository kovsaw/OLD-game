using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryScript : MonoBehaviour {
    public GameObject countPeople;
    public GameObject thui;

    int count = 0;
    // Use this for initialization
    void Start () {
		
	}

    private void OnMouseDown()
    {
        if (count <= 3)
        {
            // thui.GetComponent<thui>(count) -= 1;
            //countPeople = GameObject.Find("UIScript");
            //countPeople.GetComponent<UIScript>().count -= 10000000;
            transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z * 1.1f);
            count++;
        }

    }
    // Update is called once per frame
    void Update () {
    }
}
