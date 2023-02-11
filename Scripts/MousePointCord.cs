using UnityEngine;
using UnityEngine.UI;

public class MousePointCord : MonoBehaviour {
    public Text text;
    string point;

    void Update() {
        Vector2 point = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        text.text = point.ToString();
    }
}