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

    void FixedUpdate() // ���� ���� �����Ӹ��� ȣ��Ǵ� �����ֱ� �Լ�
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        // fixedDeltaTime:���� ������ �ϳ��� �Һ��� �ð�
        rigid.MovePosition(rigid.position + nextVec); // MovePosition�� ��ġ�̵��̶� ���� ��ġ�� ���������.

    }
}
