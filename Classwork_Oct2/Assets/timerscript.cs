﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour {

    float timeTracker;
    Slider s;
    public Text winText;

    // Use this for initialization
    void Start () {

        s = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        timeTracker = Time.time;
        s.value = timeTracker;

        if (s.value >= 5)
        {
            winText.text = "You LOSE!";
        }
	}
}
