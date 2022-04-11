using UnityEngine;

public class PneumaticRifle : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        Instantiate(_bullet, shootPoint.position, Quaternion.identity);
    }
}
