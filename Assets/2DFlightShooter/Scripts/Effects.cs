using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    private SpriteRenderer render;
    public Color hitColor;

    public GameObject explosion;


    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    public void BeAttackedEffect()
    {
        StartCoroutine(ReturnColor());
    }

    IEnumerator ReturnColor()
    {
        render.color = hitColor;
        yield return new WaitForSeconds(0.1f);
        render.color = Color.white;
    }


    public void ExplosionEffect()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
