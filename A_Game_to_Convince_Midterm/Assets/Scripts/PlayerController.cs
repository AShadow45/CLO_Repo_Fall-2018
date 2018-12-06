using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

    //public Sprite walk;
    public Sprite stand;
   // public float moveSpeed = 2f;
    public float speed;

    SpriteRenderer sr;
    //Animator anim;

    void Start () {
        sr = GetComponent<SpriteRenderer>();
       // anim = GetComponent<Animator>();
    }
	
	
	void Update () {

        if (Input.GetKey(KeyCode.W ))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            //anim.animator = walk;
        }

        if (Input.GetKey(KeyCode.A ))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        //if (Input.GetMouseButtonDown(0)) {
        //    sr.sprite = walk;
        //} else {
        //    sr.sprite = stand;
        //}
	}

   
}
