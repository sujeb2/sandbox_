using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveCustomBlock : MonoBehaviour
{
    FileBrowserUpdate pos;
    CreateCustomBlock cblock;
    private bool checkGravity;
    private bool checkCollider;
    private bool checkCircleCollider;
    string target = Application.persistentDataPath;
    //string source_file = System.IO.Path.Combine(pos.custom, pos.customPath);
    //string dest_file = System.IO.Path.Combine(target, "*.png");

    void Awake() {
        target = Application.persistentDataPath;
    }

    public void Save() {
        pos = GameObject.Find("TextureLoadManager").GetComponent<FileBrowserUpdate>();
        cblock = GameObject.Find("CustomManager").GetComponent<CreateCustomBlock>();
        Debug.Log("CustomTexture Path: " + pos.customPath);

        if(cblock.addGravity.isOn) {Debug.Log("rigidbody2d = on"); checkGravity = true;} else {Debug.Log("rigidbody2d = off"); checkGravity = false;}
        if(cblock.addCollider.isOn) {Debug.Log("box collider 2d = on"); checkCollider = true;} else {Debug.Log("box collider 2d = off"); checkCollider = false;}
        if(cblock.setCircle.isOn) {Debug.Log("circle collider 2d = on"); checkCircleCollider = true;} else {Debug.Log("circle collider 2d = off"); checkCircleCollider = false;}

        System.IO.File.Copy(pos.customPath, target, true);
    }
}