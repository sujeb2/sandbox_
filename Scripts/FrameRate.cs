using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRate : MonoBehaviour {
    List<int> fpslist = new List<int>() {60, 120, 240, 9999};

    public void SetFrameRate(int index) {
        int fpsl = fpslist[index];

        Application.targetFrameRate = fpsl;
        Debug.Log("set " + fpsl);
    }
}