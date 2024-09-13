using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction;
    public float speed;

    public int dmg;

    private const float Movement_Limit_X = 6.0f;
    private const float Movement_Limit_Y = 8.0f;

    public GameObject hitEffect;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x >= Movement_Limit_X ||
            transform.position.x <= -Movement_Limit_X ||
            transform.position.y >= Movement_Limit_Y ||
            transform.position.y <= -Movement_Limit_Y)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Stats stats = collision.GetComponent<Stats>();
        stats.GetHit(dmg);

        Instantiate(hitEffect, transform.position, Quaternion.identity);

        Destroy(this.gameObject);
    }
}
