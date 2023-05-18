using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Uzi : Weapon
{
    private WaitForSeconds _everyBulletCooldown = new WaitForSeconds(0.1f);
    private int _bulletsInSpread = 3;
    private Coroutine _spreadShooting;

    public override void Shoot(Transform shootPoint)
    {
        if (_spreadShooting != null)
        {
            StopCoroutine(_spreadShooting);
        }

        _spreadShooting = StartCoroutine(SpreadShoot(shootPoint));
    }

    private IEnumerator SpreadShoot(Transform shootPoint)
    {
        for (int i = 0; i < _bulletsInSpread; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            yield return _everyBulletCooldown;
        }
    }
}
