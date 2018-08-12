using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SecondTurtles : MonoBehaviour {

    int count = 0;
    int maxCount = 2;
    public bool lifeTurtles = true;
    public GameObject therdTurtles;
    public GameObject firstTurtles;
    public GameObject build;

    public GameObject panel;

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
        count++;
    }

    private void Update()
    {
        if (count >= maxCount)
        {
            Destroy(build);
            Destroy(firstTurtles);
            Destroy(therdTurtles);
            lifeTurtles = false;
            Destroy(gameObject);
            Destroy(this);
            Destroy(panel);
        }
    }
}
