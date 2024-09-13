using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Stats
{
    public void SetHp(int h)
    {
        hp += h;
        if (hp >= maxhp) hp = maxhp;
    }

    public void SeetAttack(int a)
    {
        attck += a;
        StartCoroutine(ReturnAttackPoint());
    }

    IEnumerator ReturnAttackPoint()
    {
        yield return new WaitForSeconds(3.0f);
        attck = baseAttack;
    }

    public float HpState()
    {
        float percent = (float)hp / maxhp;
        return percent;
    }

    public override void Death()
    {
        base.Death();

        FindObjectOfType<GameManager>().GameOver();
        Destroy(this.gameObject);
    }
}
