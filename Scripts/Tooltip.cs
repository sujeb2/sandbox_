using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public string message;

    private void OnMouseEnter() {
        TooltipBox._instance.SetAndShowToolTip(message);
    }

    private void OnMouseExit() {
        TooltipBox._instance.HideToolTip();
    }
}
