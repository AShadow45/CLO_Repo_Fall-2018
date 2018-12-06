using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFire : MonoBehaviour {

    float shotSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * shotSpeed);

        if (transform.position.x < -34 || transform.position.x > 34
            || transform.position.z < -26 || transform.position.z > 26)
        {
            Destroy(this.gameObject);
        }
    }
}
