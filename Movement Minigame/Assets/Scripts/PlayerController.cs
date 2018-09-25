using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    //public float upforce;

    void Start () {
		
	}
	
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
        }


        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
        }

    }
}
