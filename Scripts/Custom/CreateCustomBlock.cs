using UnityEngine;
using UnityEngine.UI;
using System.IO;

public static class ConvertToSprite{
    public static Sprite Convert2Sprite(this Texture2D texture){
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }
}

public class CreateCustomBlock : MonoBehaviour
{
    public Toggle addGravity;
    public Toggle addCollider;
    public Toggle setCircle;
    private int limit = 99999999;
    BoxCollider2D bc;
    SpriteRenderer sr;
    FileBrowserUpdate fbu;
    public Sprite defsp;
    public RawImage img;

    void Start() {
        fbu = GameObject.Find("TextureLoadManager").GetComponent<FileBrowserUpdate>();
    }

    public void create() {
        GameObject customObject = new GameObject();
        customObject.name = "customObject";
        customObject.tag = "CustomBlock";
        customObject.AddComponent<SpriteRenderer>();
        customObject.AddComponent<RemoveCustom>();
        limit--;
        Debug.Log("CustomBlock Left: " + limit);

        sr = customObject.GetComponent<SpriteRenderer>();
        //sr.sprite = ConvertToSprite.Convert2Sprite(img.texture);

        if(addGravity.isOn) {
            customObject.AddComponent<Rigidbody2D>();
            Debug.Log("rigidbody2d = on");
        } else {Debug.Log("rigidBody2d = off");}

        if(addCollider.isOn) {
            customObject.AddComponent<BoxCollider2D>();
            bc = customObject.GetComponent<BoxCollider2D>();
            bc.size = new Vector2(1f, 1f);
            Debug.Log("customBlock boxcollider size: " + bc.size);
            Debug.Log("boxCollider2D = on");
        } else {Debug.Log("rigidbody2d = off");}

        if(setCircle.isOn) {
            customObject.AddComponent<CircleCollider2D>();
            Debug.Log("circleCollider2D = on");
        } else {Debug.Log("circleCollider2D = off");}

    }
}
