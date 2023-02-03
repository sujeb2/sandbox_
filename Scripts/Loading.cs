using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    void loadscene() {
        SceneManager.LoadScene("Game");
        Debug.Log("Loaded");
    }

    public void fakeload() {
        SceneManager.LoadScene("fakeload");
    }
}
