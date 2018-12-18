using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadTransition : MonoBehaviour {

    public Animator transitionAnim;

    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1")) {
            StartCoroutine(LoadScene());
        }
    }
    IEnumerator LoadScene() {
        transitionAnim.SetBool("isDone", true);
        audioData.Play(0);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("WELCOME");
    }
}
