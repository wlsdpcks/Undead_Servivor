using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() // 물리 연산 프레임마다 호출되는 생명주기 함수
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        // fixedDeltaTime:물리 프레임 하나가 소비한 시간
        rigid.MovePosition(rigid.position + nextVec); // MovePosition은 위치이동이라 현재 위치도 더해줘야함.

    }
}
