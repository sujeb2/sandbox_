using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTexture : MonoBehaviour
{
    public RawImage image;
    public Texture def_Texture;

    public void clear() {
        image.texture = def_Texture;
    }

}
