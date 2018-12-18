using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPeacefulScene : MonoBehaviour {

    void ScenePeaceful()
    {
        SceneManager.LoadScene("PlantsPeacefulEnd");
    }
}
