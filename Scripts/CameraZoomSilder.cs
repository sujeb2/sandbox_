using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoomSilder : MonoBehaviour
{
    public Slider cameraspd;
    public Slider camerazmspd;
    SimpleCameraMovement scm;

    private void Awake() {
        scm = GameObject.Find("Main Camera").GetComponent<SimpleCameraMovement>();
    }

    public void CameraZoomSpeed() {
        scm.zoomIncrement = camerazmspd.value;
        Debug.Log("Current CameraZoomSpeed == " + camerazmspd.value);
    }

    public void CameraMovementSpeed() {
        scm.speed = cameraspd.value;
        Debug.Log("Current CameraSpeed == " + cameraspd.value);
    }
}
