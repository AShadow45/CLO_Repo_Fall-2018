using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    float moveForce;
    Rigidbody2D rb;
   

    void Start()
    {
        moveForce = 20;
        rb = GetComponent<Rigidbody2D>();
  
    }

 
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(1, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-1, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * moveForce, ForceMode2D.Force);
        }
        resetPos();
    }

    void resetPos()
    {
        if (transform.position.x <= -14)
        {
            transform.position = new Vector3(13, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= 14)
        {
            transform.position = new Vector3(-13, transform.position.y, transform.position.z);
        }
        if (transform.position.z <= -11)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
        if (transform.position.z >= 11)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    }

}
