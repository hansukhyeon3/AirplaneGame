using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private Vector2 dir;
    public float speed = 5.0f;

    private const float Movement_Limit_X = 8.0f;
    private const float Movement_Limit_Y = 4.6f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        dir = Vector2.down;
    }

    void Update()
    {
        rb.velocity = dir * speed;

        if(transform.position.x >= Movement_Limit_X ||
           transform.position.x <= -Movement_Limit_X ||
           transform.position.y <= -Movement_Limit_Y)
        {
            Destroy(this.gameObject);
        }
    }
}
