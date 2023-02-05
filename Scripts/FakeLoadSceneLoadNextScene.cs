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
        int rndnum = Random.Range(1, 5);
        Debug.Log("current random sec: " + rndnum);
        Invoke("loadnext", rndnum);
    }
}
