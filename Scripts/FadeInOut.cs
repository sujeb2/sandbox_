using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    SpriteRenderer sr;
    public GameObject fadeout;

    void Start() {
        sr = fadeout.GetComponent<SpriteRenderer>();
    }

    IEnumerator FadeIn()
    {
        for (int i = 0; i < 10; i++)
        {
            float f = i / 10.0f;
            Color c = sr.material.color;
            c.a = f;
            sr.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }


    IEnumerator FadeOut()
    {
        for (int i = 10; i >= 0; i--)
        {
            float f = i / 10.0f;
            Color c = sr.material.color;
            c.a = f;
            sr.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void FadeInBtn()
    {
        StartCoroutine("FadeIn");
    }

    public void FadeOutBtn()
    {
        StartCoroutine("FadeOut");
    }
}