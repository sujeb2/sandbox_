using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCustom : MonoBehaviour
{
    void OnMouseOver() {
        if(Input.GetMouseButtonDown(1)) {
            Destroy(this.gameObject);
        }
    }
}
