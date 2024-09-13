using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScrollBackGround : MonoBehaviour
{
    public Transform[] ScrolligBG = new Transform[2];

    public float speed = 3.0f;
    private  Vector2 direction = Vector2.down;

    public float imageSize;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.isPlay) return;

        for (int i = 0; i <ScrolligBG.Length; i++)
        {
            if (ScrolligBG[i].position.y <= -imageSize)
            {
                int nextIndex =
                    (i == ScrolligBG.Length - 1) ? 0 : i + 1;

                Vector2 pos = ScrolligBG[nextIndex].position;
                pos.y += imageSize;
                ScrolligBG[i].position = pos;
            }

            ScrolligBG[i].Translate(direction * speed * Time.deltaTime);
        }
    }
}
