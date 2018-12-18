
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneControls : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(ExecuteAfterTime());
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(20f);
        SceneManager.LoadScene("PlayerControls");
      
        
    }
}

