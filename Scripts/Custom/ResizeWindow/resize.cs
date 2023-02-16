using UnityEngine;

public class resize : MonoBehaviour {
    
    public GameObject window;
    public GameObject title;

    public void Downsize() {
        window.SetActive(false);
        title.SetActive(true);
    }

    public void Resize() {
        window.SetActive(true);
        title.SetActive(false);
    }

}