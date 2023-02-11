using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemController : MonoBehaviour
{
    public int ID;
    public int quantity;
    public TextMeshProUGUI quantityText;
    public bool Clicked = false;
    private LevelEditorManager editor;

    void Start()
    {
        quantityText.text = quantity.ToString();
        editor = GameObject.FindGameObjectWithTag("LevelEditorManager").GetComponent<LevelEditorManager>();
    }

    public void ButtonClicked() {
        if(quantity > 0) {
            Clicked = true;
            quantity--;
            quantityText.text = quantity.ToString();
            editor.CurrentButtonPressed = ID;
        }
    }

}
