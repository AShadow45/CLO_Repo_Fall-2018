using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * (Mathf.Sin(Time.time*5)/80));
        transform.Rotate(0, 0, Time.deltaTime * 100);
    }
}
