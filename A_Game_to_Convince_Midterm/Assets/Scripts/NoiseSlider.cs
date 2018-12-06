using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseSlider : MonoBehaviour {

    float noiseTracker;
    Slider s;
    public Text winText;

    void Start () {
        s = GetComponent<Slider>();
    }
	
	
	void Update () {
        s.value = noiseTracker;
        if (s.value >= 100)
        {
            winText.text = "You LOSE!";
        }

        if (s.value <= 10)
        {
            winText.text = "You Win!";
        }
    }
}
