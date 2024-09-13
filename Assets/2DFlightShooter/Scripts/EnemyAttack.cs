using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public enum AttackType
    {
        BODYCHECK, BULLET
    }
    public AttackType attackType = AttackType.BODYCHECK;

    public GameObject bulletPrefab;
    public float delayTime;

    private WaitForSeconds waitTime;

    private Stats stats;

    void Start()
    {
        stats = GetComponent<Stats>();

        waitTime = new WaitForSeconds(delayTime);
        if(attackType == AttackType.BULLET)
        {
            StartCoroutine(BulletAttackProcess());
        }
    }

    IEnumerator BulletAttackProcess()
    {
        yield return new WaitForSeconds(1.0f);

        while (true)
        {
            Bullet bullet = Instantiate(bulletPrefab).GetComponent<Bullet>();
            bullet.gameObject.transform.position = transform.position;
            bullet.dmg = stats.attck;

            yield return waitTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats target = collision.gameObject.GetComponent<Stats>();
        if (target != null)
        {
            Debug.Log("Stats ������Ʈ�� �浹�� ���� ������Ʈ�� �ֽ��ϴ�.");
            if (stats != null)
            {
                target.GetHit(stats.attck);
            }
            else
            {
                Debug.LogError("EnemyAttack�� stats�� null�Դϴ�.");
            }
        }
        else
        {
            Debug.LogWarning("�浹�� ���� ������Ʈ�� Stats ������Ʈ�� �����ϴ�.");
        }

        Destroy(this.gameObject);
    }
}
