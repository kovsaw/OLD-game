using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTurtleScript : MonoBehaviour
{

    int count = 0;
    int maxCount = 2;
    public bool lifeTurtles = true;

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
        count++;
    }

    private void Update()
    {
        if (count >= maxCount)
        {
            lifeTurtles = false;
            Destroy(gameObject);
        }
    }
}
