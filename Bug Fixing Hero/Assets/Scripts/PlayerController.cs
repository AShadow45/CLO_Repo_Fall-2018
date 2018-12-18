using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            anim.SetBool("isRunningUp", true);
        }else{
            anim.SetBool("isRunningUp", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            anim.SetBool("isRunningLeft", true);
        }else{
            anim.SetBool("isRunningLeft", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
            anim.SetBool("isRunningDown", true);
        }else{
            anim.SetBool("isRunningDown", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            anim.SetBool("isRunningRight", true);
        }else {
            anim.SetBool("isRunningRight", false);
        }
    }

}
