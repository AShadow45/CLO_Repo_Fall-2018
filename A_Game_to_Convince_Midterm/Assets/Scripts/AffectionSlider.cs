using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AffectionSlider : MonoBehaviour {

    float affectionTracker;
    Slider s;
    public Text winText;
    public float hp;


    void Start () {
        s = GetComponent<Slider>();
        hp = 0;
    }
	
	
	void Update () {
        s.value = affectionTracker;
        if (s.value >= 20)
        {
            winText.text = "You Win!";
        }

        if (s.value <= 1)
        {
            winText.text = "You LOSE!";
        }
    }
}
