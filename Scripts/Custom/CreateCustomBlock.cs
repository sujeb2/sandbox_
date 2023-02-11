using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

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
    public Toggle setSpringJoint;
    public Input x;
    public Input y;
    bool isGravityOn = false;
    bool isColliderOn = false;
    bool isCircleColliderOn = false;
    bool isSpringJointOn = false;
    bool isTrailEffectOn = false;
    private int limit = 99999999;
    BoxCollider2D bc;
    SpriteRenderer sr;
    SpringJoint2D sp;
    FileBrowserUpdate fbu;
    MousePointCord point;
    public Sprite defsp;
    public RawImage img;

    void Start() {
        fbu = GameObject.Find("TextureLoadManager").GetComponent<FileBrowserUpdate>();
    }

    public void create() {
        try {
            GameObject customObject = new GameObject();
            customObject.name = "customObject";
            customObject.tag = "CustomBlock";
            customObject.AddComponent<SpriteRenderer>();
            customObject.AddComponent<RemoveCustom>();
            limit--;
            Debug.Log("CustomBlock Left: " + limit);

            sr = customObject.GetComponent<SpriteRenderer>();
            try {
            sr.sprite = ConvertToSprite.Convert2Sprite(img.texture as Texture2D);
            Debug.Log("Texture Loaded Successfully!");
            Debug.Log("Block texture path:" + fbu.customPath);
            }
            catch(Exception ex) {
                Debug.LogError("Trying to load texture: " + fbu.customPath + " but failed.");
                Debug.LogError("Reason: " + ex.Message);
            }
            finally {
                Debug.Log("Done.");
            }

            if(addGravity.isOn) {
                customObject.AddComponent<Rigidbody2D>();
                isGravityOn = true;
            } else {isGravityOn = false;}

            if(addCollider.isOn) {
                customObject.AddComponent<BoxCollider2D>();
                bc = customObject.GetComponent<BoxCollider2D>();
                bc.size = new Vector2(1f, 1f);
                Debug.Log("customBlock boxcollider size: " + bc.size);
                isColliderOn = true;
            } else {isColliderOn = false;}

            if(setCircle.isOn) {
                customObject.AddComponent<CircleCollider2D>();
                isCircleColliderOn = true;
            } else {isCircleColliderOn = false;}

            if(setCircle.isOn) {
                customObject.AddComponent<SpringJoint2D>();
                sp = customObject.GetComponent<SpringJoint2D>();
                isSpringJointOn = true;
            } else {isSpringJointOn = false;}
            Debug.Log("Rigidbody2D = " + isGravityOn + ", BoxCollider2D = " + isColliderOn + ", CircleCollider2D = " + isCircleColliderOn + ", SpringJoint2D = " + isSpringJointOn + ", TrailEffect = " + isTrailEffectOn);            
        }
        catch(Exception ex) {
            Debug.LogError("An Error occured while trying to create customBlock.");
            Debug.LogError("Reason: " + ex.Message);
        }
        finally {
            Debug.Log("Created customBlock");
        }
    }
}
