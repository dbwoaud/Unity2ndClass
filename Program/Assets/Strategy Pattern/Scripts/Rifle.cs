using UnityEngine;

public class Rifle : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform muzzle;

    public override void Attack()
    {
        Instantiate(bullet, muzzle);
    }
}
