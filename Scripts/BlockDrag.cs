using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockDrag : MonoBehaviour
{
    float distance = 10.0f;
    public void OnDrag(PointerEventData eventData)
    { 
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        transform.position = mousePosition;
    }
}
