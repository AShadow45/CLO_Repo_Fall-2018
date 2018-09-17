using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour {

    public float speed;
    // Use this for initialization
    void Start () {
		
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left *speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right *speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * upforce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.down * upforce);
        }
    }

    void OnCollisionEnter (Collision other) {
        //Debug.Log("I touched something!!");
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Sphere") {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnCollisionStay (Collision other) {
        Debug.Log("I'm still touching!!");
        //GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        if (other.gameObject.tag == "Sphere") {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnCollisionExit (Collision other) {
        Debug.Log("No longer touching something!!");
        if (other.gameObject.tag == "Sphere") {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public float upforce;

     void OnMouseDown() {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
    }

    void OnTriggerEnter(Collider other)
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
    }

    void OnTriggerExit(Collider other)
    {

    }
}
