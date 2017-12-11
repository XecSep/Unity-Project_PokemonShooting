/*
 * 배경(스크롤)을 움직인다. 
 */

using UnityEngine;
using System.Collections;

public class BackScroller : MonoBehaviour {

    public float scrollSpeed = 0.5F;    //스크롤 속도이다.
    Renderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        myRenderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));   //x=offset 횡스크롤한다. //y=offset 종스크롤한다.
    }
}
