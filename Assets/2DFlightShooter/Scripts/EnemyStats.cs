using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : Stats
{
    public int enemyScore;

    public override void Death()
    {
        base.Death();

        GameManager.score += enemyScore;
        Destroy(this.gameObject);
    }
}
