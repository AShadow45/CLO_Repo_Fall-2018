using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showCollected : MonoBehaviour {

    public Image Cards, Mushroom, Heart1, Heart2, Heart3;

    void Start() {
        Heart1.enabled = false;
        Heart2.enabled = false;
        Heart3.enabled = false;
    }

	void Update () {
        Cards.enabled = GameManager.control.cardsUnlocked;
        Mushroom.enabled = GameManager.control.mushroomUnlocked;

        if (GameManager.control.heartCount >= 1)
        {
            Heart1.enabled = true;
        }
        if (GameManager.control.heartCount >= 2)
        {
            Heart2.enabled = true;
        }
        if (GameManager.control.heartCount >= 3)
        {
            Heart3.enabled = true;
        }
    }
}
