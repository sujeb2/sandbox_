using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour {
    public void load() {
        SceneManager.LoadScene("Game");
    }
}