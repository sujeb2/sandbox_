using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetDefaultResolution : MonoBehaviour {
    
    void Awake() {
        Debug.Log("Current Screen Resolution: " + Screen.height + " x " + Screen.width);
        if(Screen.height < 640){
            Screen.SetResolution(1600, 900, false);
            Debug.LogWarning("Game Window resolution set to default because of window resolution is too small.");
        }
        if(Screen.width < 480){
            Screen.SetResolution(1600, 900, false);
            Debug.LogWarning("Game Window resolution set to default because of window resolution is too small.");
        }
    }
}