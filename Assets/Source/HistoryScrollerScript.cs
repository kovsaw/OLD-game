using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoryScrollerScript : MonoBehaviour {
    public void Update () {
        float scrollSpeed = 20;

        // get current position of parent GameObject
        Vector3 position = transform.position;

        // get vector pointing into the distance
        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

        // move the text object into the distance to give our 3D scrolling effect
        position += localVectorUp * scrollSpeed * Time.deltaTime;
        transform.position = position;    
	}
}
