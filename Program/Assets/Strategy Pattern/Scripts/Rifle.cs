using UnityEngine;

public class Rifle : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform muzzle;
    private void Awake()
    {
        muzzle = transform.Find("muzzle");
    }
    public override void Attack()
    {
        GameObject clone = Instantiate(bullet,muzzle.position,muzzle.rotation);
        clone.AddComponent<Bullet>();
    }
}
