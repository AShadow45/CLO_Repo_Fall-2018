using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager control;

    public bool cardsUnlocked, mushroomUnlocked;
    public int heartCount;

    void Awake()
    {
        
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;   // this means this script
        }
        else if (control != this)
        {
            Destroy(gameObject);  // there can be only one
        }
    }

    void Start() {
        cardsUnlocked = false;
        mushroomUnlocked = true;
        heartCount = 0;
    }

}
