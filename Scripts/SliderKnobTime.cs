using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderKnobTime : MonoBehaviour
{
    public Slider slider;
    
    public void Update() {
        Time.timeScale = slider.value;
        print(slider.value);
    }
}
