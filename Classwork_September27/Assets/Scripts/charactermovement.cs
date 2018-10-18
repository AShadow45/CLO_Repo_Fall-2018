using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float val;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * val, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * val, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * val, ForceMode2D.Impulse);
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
    }
}
