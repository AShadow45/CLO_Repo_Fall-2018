using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public Transform gunEnd;
    private Camera fpsCam;

	// Use this for initialization
	void Start () {
        fpsCam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0f));
            RaycastHit hit;

            Debug.DrawRay(rayOrigin, fpsCam.transform.forward);

            if (Physics.Raycast (rayOrigin,fpsCam.transform.forward, out hit))
            {
                Debug.Log(hit.collider.tag);
            }
        }
	}
}
