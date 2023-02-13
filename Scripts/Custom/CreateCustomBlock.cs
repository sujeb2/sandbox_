using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Collections;

public static class ConvertToSprite{
    public static Sprite Convert2Sprite(this Texture2D texture){
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }
}

public class CreateCustomBlock : MonoBehaviour
{
    // toggle
    public Toggle addGravity;
    public Toggle addCollider;
    public Toggle setCircle;
    public Toggle setSpringJoint;
    public Toggle setNormalSize;
    public Toggle addTrailEffect;

    // input
    public InputField x;
    public InputField y;
    
    // bool
    bool isGravityOn = false;
    bool isColliderOn = false;
    bool isCircleColliderOn = false;
    bool isSpringJointOn = false;
    bool isTrailEffectOn = false;
    bool isSetNativeSizeOn = false;

    // etc...
    BoxCollider2D bc;
    SpriteRenderer sr;
    SpringJoint2D sp;
    FileBrowserUpdate fbu;
    MousePointCord point;
    TrailRenderer tr;
    
    // set
    public Sprite defsp;
    public RawImage img;
    public Material defmat;
    public Vector2 nativeSize;

    void Start() {
        nativeSize = new Vector3(0.5f, 0.5f, 1f);
        try {
        fbu = GameObject.Find("TextureLoadManager").GetComponent<FileBrowserUpdate>();
        } catch (Exception ex) {
            Debug.LogError("Failed to load 'TextureLoadManager'.");
            Debug.LogError("Reason: " + ex.Message);
        } finally {
            Debug.Log("Loaded.");
        }
    }

    public void create() {
        try {
            GameObject customObject = new GameObject();
            customObject.name = "customObject";
            customObject.tag = "CustomBlock";
            customObject.AddComponent<SpriteRenderer>();
            customObject.AddComponent<RemoveCustom>();
            customObject.AddComponent<DragNDrop>();

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

            if(setSpringJoint.isOn) {
                customObject.AddComponent<SpringJoint2D>();
                sp = customObject.GetComponent<SpringJoint2D>();
                //sp.anchor = 
                isSpringJointOn = true;
            } else {isSpringJointOn = false;}
            
            if(setNormalSize.isOn) {
                customObject.transform.localScale = nativeSize;
                Debug.Log("customBlock Sprite size: " + sr.size);
                isSetNativeSizeOn = true;
            } else {isSetNativeSizeOn = false;}

            if(addTrailEffect.isOn) {
                customObject.AddComponent<TrailRenderer>();
                tr = customObject.GetComponent<TrailRenderer>();
                tr.time = 1.0f;
                tr.material = defmat;
                tr.startWidth = 0.2f;
                isTrailEffectOn = true;
            } else {isTrailEffectOn = false;}
            Debug.Log("Rigidbody2D = " + isGravityOn + ", BoxCollider2D = " + isColliderOn + ", CircleCollider2D = " + isCircleColliderOn + ", SpringJoint2D = " + isSpringJointOn + ", TrailEffect = " + isTrailEffectOn + ", SetNativeSize = " + isSetNativeSizeOn);            
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
