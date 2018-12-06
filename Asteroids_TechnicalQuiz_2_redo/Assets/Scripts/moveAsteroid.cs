using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAsteroid : MonoBehaviour {

    public float speed;
    float posX, posZ;
    public float hp;

    void Start()
    {
        posX = Random.Range(-34, 34);
        posZ = Random.Range(-26, 26);

        transform.position = new Vector3(posX, 0, posZ);

        Vector3 euler = transform.eulerAngles;
        euler.y = Random.Range(0f, 360f);
        transform.eulerAngles = euler;

        hp = Random.Range(1, 4);
        transform.localScale = new Vector3(hp + 2, hp + 2, hp + 2);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        speed = 5 - hp;
        Screenwrap();
    }

    void Screenwrap()
    {
        if (transform.position.x < -34)
        {
            transform.position = new Vector3(33, transform.position.y, transform.position.z);
        }

        if (transform.position.x < 34)
        {
            transform.position = new Vector3(-33, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -26)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 25);
        }

        if (transform.position.z < 26)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -25);
        }
    }
}
