using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidControl : MonoBehaviour {


    //   public float spawnTime = 3f;
    //   public Transform[] spawnPoints;

    //   public float waitingForNextRock = 10;
    //   public float waittime = 10;

       public float xMin;
       public float xMax;

       public float yMin;
       public float yMax;

    //   void Start () {
    //       InvokeRepeating("Spawn", spawnTime, spawnTime);
    //   }


    //void Update () {
    //       waittime -= Time.deltaTime;
    //       if (waittime <= 0)
    //       {
    //           Spawnspacerocks();
    //           waittime = waitingForNextRock;
    //       }
    //   }

    //   void Spawnspacerocks()
    //   {
    //       Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));




    //   }

    //   void Spawn()
    //   {

    //       // Find a random index between zero and one less than the number of spawn points.
    //       int spawnPointIndex = Random.Range(0, spawnPoints.Length);

    //       // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
    //       Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    //   }

    //previous attempts above
    //-----------------------------------------------------------------------------------------------------------------------------------------------


    public GameObject spacerock;
    float timer = 0;

    GameObject[] rocks;

    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= 5)
        {
            GameObject Clone = Instantiate (spacerock, new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax)), Quaternion.identity);
            //Clone.transform.localScale = new Vector2(Random.Range(2f, 8f), 1f);
            timer = 0;
        }

        rocks = GameObject.FindGameObjectsWithTag("Asteroid");

        foreach (GameObject platform in rocks)
        {
            spacerock.transform.localPosition = new Vector2(spacerock.transform.localPosition.x, spacerock.transform.localPosition.y - 0.1f);

           // if (spacerock.transform.localPosition.y < -6)
            //{
             //   Destroy(spacerock);
            }
        }


    }

}
