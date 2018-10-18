using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRaycast : MonoBehaviour {

    public float height = 5;

	void Start () {
		
	}
	
	
	void Update () {
        RaycastHit hit;

        Debug.DrawRay(transform.position, Vector3.down * 5, Color.red);

        if (Physics.Raycast (transform.position, Vector3.down, out hit, height))
        {
            Debug.Log(hit.collider.tag);

            if (hit.collider.tag == "ground")
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
	}
}
