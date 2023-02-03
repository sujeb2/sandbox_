using UnityEngine;

public class ToggleFullScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void fullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("set fullscreen.");
    }
}
