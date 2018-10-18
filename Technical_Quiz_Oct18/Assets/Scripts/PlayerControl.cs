using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float force = 300;
    public float speed = 2;
    public bool isDead = false;

    private Animator anim;
    private Rigidbody2D rb2d;
	
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
	
	
	void Update () {
        if (isDead == false) {
            if (Input.GetKeyDown(KeyCode.Space)){
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            }
        }
        
	}

    
}
