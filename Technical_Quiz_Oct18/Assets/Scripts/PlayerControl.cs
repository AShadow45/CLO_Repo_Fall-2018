﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float force = 300;
    public float speed = 2;
   

 
	
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)){
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
        
	}

    
}
