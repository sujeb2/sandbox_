using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipBox : MonoBehaviour
{
    public static TooltipBox _instance;

    public TextMeshProUGUI text;

    private void Awake() {
        if (_instance != null && _instance != this) {
            Destroy(this.gameObject);
        }
        else {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetAndShowToolTip(string message) {
        gameObject.SetActive(true);
        text.text = message;
    }
    
    public void HideToolTip() {
        gameObject.SetActive(false);
        text.text = string.Empty;
    }
}
