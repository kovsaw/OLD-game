using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SecondTurtleScript : MonoBehaviour {

    int count = 0;
    int maxCount = 2;
    public bool lifeTurtles = true;
    public GameObject thirdTurtle;
    public GameObject firstTurtle;
    public GameObject building;

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
            Destroy(building);
            Destroy(firstTurtle);
            Destroy(thirdTurtle);
            lifeTurtles = false;
            Destroy(gameObject);
            Destroy(this);
            Destroy(panel);
        }
    }
}
