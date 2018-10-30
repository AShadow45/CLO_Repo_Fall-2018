using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour {

    private AudioSource source;
    public AudioClip catPurr;

    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    void Awake() {
        source = GetComponent<AudioSource>();
    }


    void Update () {
		
	}

    void OnMouseDown()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        source.PlayOneShot(catPurr, vol);
    }
}
