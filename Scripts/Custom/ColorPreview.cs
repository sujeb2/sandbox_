using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ColorPreview : MonoBehaviour {
    
    public Image preview;
    public Slider red;
    public Slider green;
    public Slider blue;
    public Slider Alpha;

    public float rvalue = 0.0F;
    public float gvalue = 0.0F;
    public float bvalue = 0.0F;
    public float avalue = 1.0F;

    void Start() {
        rvalue = red.value;
        gvalue = green.value;
        bvalue = blue.value;
        avalue = Alpha.value;
    }

    void Update() {
        try {
            preview.GetComponent<Image>().color = new Color32((byte) rvalue, (byte) gvalue, (byte) bvalue, (byte) avalue);
        } catch (Exception ex) {
            Debug.LogError("An error ocurred while trying to set color.");
            Debug.LogError("Reason: " + ex.Message);
        }
    }

}