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
    public Toggle addParticleEffect;

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
    bool isAddPaticleEffectOn = false;

    // etc...
    BoxCollider2D bc;
    SpriteRenderer sr;
    SpringJoint2D sp;
    FileBrowserUpdate fbu;
    MousePointCord point;
    TrailRenderer tr;
    ParticleSystem ps;
    
    // set
    public Sprite defsp;
    public RawImage img;
    public Material defmat;
    public Vector2 nativeSize;

    // particle
    public Toggle loopToggle;
    public Toggle flipToggle;
    public Toggle noiseToggle;

    public Slider startSpeedSlider;
    public Slider startDelaySlider;
    public Slider startRotationSlider;
    public Slider particleGravitySlider;
    public Slider maxParticleSlider;
    public Slider particleDurationSlider;
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;
    public Slider aslider;

    public InputField particleX;
    public InputField particleY;
    public Material defmater;
    public Vector3 pivot;

    public float hSliderValueR = 0.0F;
    public float hSliderValueG = 0.0F;
    public float hSliderValueB = 0.0F;
    public float hSliderValueA = 1.0F;

    void Start() {
        nativeSize = new Vector3(0.5f, 0.5f, 1f);
        try {
        fbu = GameObject.Find("TextureLoadManager").GetComponent<FileBrowserUpdate>();
        } catch (Exception ex) {
            Debug.LogError("Failed to load 'TextureLoadManager'.");
            Debug.LogError("Reason: " + ex.Message);
        } finally {
            Debug.Log("Loaded TextureLoadManager.");
        }
        //try {
        //fpu = GameObject.Find("TextureLoadManager").GetComponent<FlieBrowserUpdateParticle>();
        //} catch (Exception ex) {
        //    Debug.LogError("Failed to load 'TextureLoadManager'.");
        //    Debug.LogError("Reason: " + ex.Message);
        //} finally {
        //    Debug.Log("Loaded TextureLoadManager.");
        //}
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

            if(addParticleEffect.isOn) {
                try {
                    ParticleSystemRenderer psr;
                    customObject.AddComponent<ParticleSystem>();
                    ps = customObject.GetComponent<ParticleSystem>();
                    psr = customObject.GetComponent<ParticleSystemRenderer>();
                    hSliderValueR = redSlider.value;
                    hSliderValueG = greenSlider.value;
                    hSliderValueB = blueSlider.value;
                    hSliderValueA = aslider.value;
                    //pivot.x = particleX
                    //pivot.y = particleY;
                    pivot.z = 0; 

                    var noise = ps.noise;
                    var pmain = ps.main;

                    psr.material = defmater;
                    psr.pivot = pivot;
                    pmain.startColor = new Color(hSliderValueR, hSliderValueG, hSliderValueB, hSliderValueA);
                    //render.pivot(4.0f, 0f, 0f);

                    pmain.startDelay = startDelaySlider.value;
                    pmain.startRotation = startRotationSlider.value;
                    pmain.maxParticles = (int)maxParticleSlider.value;
                    pmain.startSize = particleDurationSlider.value;
                    pmain.startRotation = startRotationSlider.value;

                    if(noiseToggle.isOn) {noise.enabled = true;}
                    if(loopToggle.isOn) {pmain.loop = true;}
                    if(flipToggle.isOn) {pmain.flipRotation = 1;}

                    Debug.Log("flipRotation = " + pmain.flipRotation + " noiseMap = " + noise.enabled + " loop = " + pmain.loop + " startDelay = " + pmain.startDelay + " startRotation = " + pmain.startRotation + " maxParticle = " + pmain.maxParticles + " duration = " + pmain.duration);

                    isAddPaticleEffectOn = true;
                } catch (Exception ex) {
                    Debug.LogError("An Error occured while trying to setup particle system.");
                    Debug.LogError("Reason: " + ex.Message);
                } finally {
                    Debug.Log("Added particle system.");
                }
            } else {isAddPaticleEffectOn = false;}

            Debug.Log("Rigidbody2D = " + isGravityOn + ", BoxCollider2D = " + isColliderOn + ", CircleCollider2D = " + isCircleColliderOn + ", SpringJoint2D = " + isSpringJointOn + ", TrailEffect = " + isTrailEffectOn + ", SetNativeSize = " + isSetNativeSizeOn + ", AddParitcleEffect = " + isAddPaticleEffectOn);            
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
