using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    private Stats stats;

    void Start()
    {
        stats = GetComponent<Stats>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootTheBullet();
        }
    }

    private void ShootTheBullet()
    {
        Bullet bullet = Instantiate(bulletPrefab).GetComponent<Bullet>();
        bullet.dmg = stats.attck;
        bullet.gameObject.transform.position = transform.position;
        bullet.gameObject.transform.rotation = transform.rotation;
    }
}
