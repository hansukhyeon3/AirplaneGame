using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;

    public float delayTime = 3.0f;
    private float t = 0.0f;

    void Update()
    {
        if (GameManager.isPlay == false) return;

        t += Time.deltaTime;
        if (t >= delayTime)
        {
            SpawnEnemies();
            t = 0.0f;
        }
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex],
                spawnPoints[i].position, Quaternion.identity);
        }
    }
}
