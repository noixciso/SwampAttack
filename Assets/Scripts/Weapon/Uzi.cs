using System.Collections;
using UnityEngine;

public class Uzi : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        StartCoroutine(ShootBurst(shootPoint));
    }
    
    private IEnumerator ShootBurst(Transform shootPoint)
    {
        Instantiate(_bullet, shootPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(_bullet, shootPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(_bullet, shootPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(_bullet, shootPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(_bullet, shootPoint.position, Quaternion.identity);
    }
}