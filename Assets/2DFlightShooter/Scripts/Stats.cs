using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Effects))]
public class Stats : MonoBehaviour
{
    public int hp;
    public int maxhp { get; private set; }

    public int attck;
    public int baseAttack {  get; private set; }

    private void Awake()
    {
        maxhp = hp;
        baseAttack = attck;
    }

    public void GetHit(int damage)
    {
        hp -= damage;

        GetComponent<Effects>().BeAttackedEffect();

        if(hp <= 0) 
        {
            hp = 0;
            Death();
        }
    }

    public virtual void Death()
    {
        GetComponent<Effects>().ExplosionEffect();
    }
}
