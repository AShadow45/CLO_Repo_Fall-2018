using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 5;
    public object PlayerCamera;

    void Start()
    {

    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        transform.Rotate(Input.mousePosition.x, Input.mousePosition.y);

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");

           

            if (Input.GetButton("Fire1"))
            {

            }

        }
      
        // if i wanted the player to be follow mouse [directly under cursor]
        //target = PlayerCamera.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 
        //  Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

    }

}
