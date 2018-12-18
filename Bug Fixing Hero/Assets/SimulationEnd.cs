using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimulationEnd : MonoBehaviour {

    void NextSceneSimulationEnd() {
        SceneManager.LoadScene("SimulatorEnd");
    }
}
