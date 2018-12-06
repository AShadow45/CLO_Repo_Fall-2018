using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLevelObjects : MonoBehaviour {

    public GameObject CardsGate;
    public GameObject Heart1, Heart2, Heart3;

    void Start()
    {
        CardsGate.SetActive(GameManager.control.cardsUnlocked);
    }
}
