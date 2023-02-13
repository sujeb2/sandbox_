using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
    List<int> widths = new List<int>() {1920, 1600, 1280};
    List<int> heights = new List<int>() {1080, 900, 720};

    public void SetScreenSize(int index) {
        int width = widths[index];
        int height = heights[index];

        Screen.SetResolution(width, height, false);
        Debug.Log("set resolution to: " + width + " x " + height);

    }
}
