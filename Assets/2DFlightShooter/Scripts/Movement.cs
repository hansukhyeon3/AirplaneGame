using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb; // 콤포넌트 값을 가져옴

    public float speed; // 플레이어 이동속도
    private Vector3 direction;

    private const float Movement_Limit_X = 6.15f; //좌우 최대 이동 거리
    private const float Movement_Limit_Y = 4.60f; //상하 최대 이동 거리

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
