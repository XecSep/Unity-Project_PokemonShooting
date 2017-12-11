/*
 * 배경(스크롤)을 움직인다. 
 */

////https://docs.unity3d.com/ScriptReference/Material.SetTextureOffset.html
//using UnityEngine;
//using System.Collections;

//public class BackScroller : MonoBehaviour {

//    public float scrollSpeed = 0.5F;    //스크롤 속도이다.
//    Renderer myRenderer;

//    void Start()
//    {
//        myRenderer = GetComponent<Renderer>();
//    }

//    void Update()
//    {
//        float offset = Time.time * scrollSpeed;
//        myRenderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));   //(x=offset, 0) 횡스크롤한다. //(0, y=offset) 종스크롤한다.
//    }
//}

/*
 * 구분선이다.
 */

//김웅남. 유니티 2D 슈팅 게임 개발 특강.
using UnityEngine;
using System.Collections;

public class BackScroller : MonoBehaviour
{

    public float scrollSpeed = 1.5f;    //스크롤 속도이다.
    Material myMaterial;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //float newOffsetX = myMaterial.mainTextureOffset.x + scrollSpeed * Time.deltaTime;   //횡스크롤을 위한 변수이다.
        float newOffsetY = myMaterial.mainTextureOffset.y + scrollSpeed * Time.deltaTime;   //종스크롤을 위한 변수이다.
        Vector2 newOffset = new Vector2(0, newOffsetY); //(x=offsetX, 0) 횡스크롤한다. //(0, y=offsetY) 종스크롤한다.

        myMaterial.mainTextureOffset = newOffset;
    }
}
