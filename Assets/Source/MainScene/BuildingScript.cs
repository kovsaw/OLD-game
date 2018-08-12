using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BuildingScript : MonoBehaviour {
    public Text countPeople;
    int count = 0;
    Int64 peopleCount;

    private void OnMouseDown()
    {
        peopleCount = Convert.ToInt64(countPeople.text);
        peopleCount -= 50000000;
        countPeople.text = peopleCount.ToString();

        if (count <= 3)
        {
            transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z * 1.1f);
            count++;
        }
    }
}