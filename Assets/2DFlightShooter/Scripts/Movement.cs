using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb; // ������Ʈ ���� ������

    public float speed; // �÷��̾� �̵��ӵ�
    private Vector3 direction;

    private const float Movement_Limit_X = 6.15f; //�¿� �ִ� �̵� �Ÿ�
    private const float Movement_Limit_Y = 4.60f; //���� �ִ� �̵� �Ÿ�

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        direction = new Vector2(x, y);
        direction.Normalize();

        MovementLimit();
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void MovementLimit()
    {
        Vector3 pos = transform.position;

        if (transform.position.x >= Movement_Limit_X)
            pos.x = Movement_Limit_X;
        if (transform.position.x <= -Movement_Limit_X)
            pos.x = -Movement_Limit_X;

        if (transform.position.y >= Movement_Limit_Y)
            pos.y = Movement_Limit_Y;
        if (transform.position.y <= -Movement_Limit_Y)
            pos.y = -Movement_Limit_Y;

        transform.position = pos;
    }
}
