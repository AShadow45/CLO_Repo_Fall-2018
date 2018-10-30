using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Sprite walk;
    public Sprite stand;
    public float moveSpeed = 2f;

    SpriteRenderer sr;
    //Animator anim;

    void Start () {
        sr = GetComponent<SpriteRenderer>();
        //anim = GetComponent<Animator>();
    }
	
	
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            sr.sprite = walk;
        } else {
            sr.sprite = stand;
        }
	}

   
}
