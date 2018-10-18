using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeplatform : MonoBehaviour {

    public GameObject platform;
    float timer = 0;

    GameObject[] platforms;

	void Start () {
        
	}
	
	
	void Update () {

        timer += Time.deltaTime;

        if (timer >= 2) {
            GameObject Clone = Instantiate(platform, new Vector2(Random.Range(-8f, 8f), 6f), Quaternion.identity);
            Clone.transform.localScale = new Vector2(Random.Range (2f, 8f), 1f);
            timer = 0;
        }

        platforms = GameObject.FindGameObjectsWithTag ("Platform");

        foreach (GameObject platform in platforms)
        {
            platform.transform.localPosition = new Vector2(platform.transform.localPosition.x, platform.transform.localPosition.y - 0.1f);

            if (platform.transform.localPosition.y < -6)
            {
                Destroy(platform);
            }
        }

        //Clone.transform.localPosition = new Vector2(Clone.transform.localPosition.x, Clone.transform.localPosition.y - 0.1f);

       // if (Clone.transform.localPosition.y < -6) {
            //Destroy(Clone);
        //}

       
    }
}
