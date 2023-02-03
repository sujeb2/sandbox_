using UnityEngine;
using UnityEngine.UI;

public class CreateCustomBlock : MonoBehaviour
{
    public Toggle addGravity;
    public Toggle addCollider;
    public Toggle setCircle;
    public RawImage img;
    BoxCollider2D bc;
    SpriteRenderer sr;

    public void create() {
        GameObject customObject = new GameObject();
        customObject.name = "customObject";
        customObject.tag = "CustomBlock";
        customObject.AddComponent<SpriteRenderer>();
        customObject.AddComponent<RemoveCustom>();

        sr = customObject.GetComponent<SpriteRenderer>();
        // need to fix
        // sr.sprite = img.texture;

        if(addGravity.isOn) {
            customObject.AddComponent<Rigidbody2D>();
        }

        if(addCollider.isOn) {
            customObject.AddComponent<BoxCollider2D>();
            bc = customObject.GetComponent<BoxCollider2D>();
            bc.size = new Vector2(1f, 1f);
            Debug.Log("customBlock boxcollider size: " + bc.size);
        }

        if(setCircle.isOn) {
            customObject.AddComponent<CircleCollider2D>();
        }

    }
}
