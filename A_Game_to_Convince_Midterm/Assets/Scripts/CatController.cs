using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour {

    AudioSource pur;
    float affectionTracker;

    void Awake() {
        pur = GetComponent<AudioSource>();
    }


    void Update () {
        OnMouseDown();
	}

    void OnMouseDown()
    {
        pur.Play();

        float currAfec = GetComponent<AffectionSlider>().hp;
        currAfec++;
    }
}
