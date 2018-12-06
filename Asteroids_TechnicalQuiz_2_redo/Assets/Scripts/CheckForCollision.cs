using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag = "shot")
        {
            float currHp = GetComponent<moveAsteroid>().hp;
            if (currHp > 0)
            {
                currHp--;
                transform.localScale = new Vector3(currHp * 2, currHp * 2, currHp * 2);
                GetComponent<moveAsteroid>().hp = currHp;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        if (other.gameObject.tag = "Player")
        {
            Debug.Log("ship hit");
            Destroy(other.gameObject);
        }
    }
}
