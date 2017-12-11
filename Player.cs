/*
 * 플레이어를 움직인다.
 */

//김웅남. 유니티 2D 슈팅 게임 개발 특강.
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float moveSpeed = 0.5f;  //이동속도이다.

	void Start ()
    {
	
	}
	
    void MoveControl()  //사용자가 움직임을 조작한다.
    {
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"); //↔ 키를 누르면 x축으로 움직인다.
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");   //↕ 키를 누르면 y축으로 움직인다.
        transform.Translate(moveX, moveY, 0);

        //print(Input.GetAxis("Horizontal"));   //↔ 키를 누르면 -1~1 값을 반환한다.
        //print(Input.GetAxis("Vertical"));   //↕ 키를 누르면 -1~1 값을 반환한다.
    }

    void Update ()
    {
        MoveControl();
	}
}
