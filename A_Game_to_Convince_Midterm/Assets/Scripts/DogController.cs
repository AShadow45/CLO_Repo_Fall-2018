using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCeontroller : MonoBehaviour {

    AudioSource bark;
    float affectionTracker;

    void Awake()
    {
        bark = GetComponent<AudioSource>();
    }


    void Update()
    {
        OnMouseDown();
    }

    void OnMouseDown()
    {
        bark.Play();

        float currAfec = GetComponent<AffectionSlider>().hp;
        currAfec++;
    }
}
