using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showNextLevel : MonoBehaviour {

    public GameObject key, enemy;

	void Start () {
        
        if (GameManager.control.heartCount >= 3)
        {
            enemy.SetActive(false);

        }
        else {
            key.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
