using UnityEngine;

public class DragNDrop : MonoBehaviour {
    void OnMouseDrag() {
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos() {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}