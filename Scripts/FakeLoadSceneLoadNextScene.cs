using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeLoadSceneLoadNextScene : MonoBehaviour
{
    void loadnext() {
        SceneManager.LoadScene("Game");
        Debug.Log("Loaded");
    }

    void Start() {
        Invoke("loadnext", 3.0f);
    }
}
