using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeAsteroid : MonoBehaviour {

    public GameObject asteroid;

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Instantiate(asteroid, new Vector3(10, 0, 0), Quaternion.identity);
        }
    }
}
