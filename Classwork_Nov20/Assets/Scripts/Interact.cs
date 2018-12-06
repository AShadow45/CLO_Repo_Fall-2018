using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heart")
        {
            GameManager.control.heartCount++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "gate")
        {
            if (other.gameObject.name == "CardsGate")
            {
                SceneManager.LoadScene("cards");
            }

            if (other.gameObject.name == "HomeGate")
            {
                SceneManager.LoadScene("home");
            }
        }

        if (other.gameObject.tag == "key")
        {
            GameManager.control.mushroomUnlocked = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }

    }
}

