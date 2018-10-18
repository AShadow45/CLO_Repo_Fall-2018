using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeAction : MonoBehaviour {

    public Slider cubecount;
    public Text winText;
	
	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnMouseDown() {
        float value = cubecount.value;
        Debug.Log(value);
        cubecount.value = value + 1;
        Destroy(this.gameObject);

        if (cubecount.value <= 1)
        {
            winText.text = "";
        } else if (cubecount.value == 5){
            winText.text = "You Win!";
        }
    }
}
