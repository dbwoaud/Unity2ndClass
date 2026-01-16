using UnityEngine;

public class Rifle : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform muzzle;
    [SerializeField] float speed = 1f;
    private void Awake()
    {
        muzzle = transform.Find("muzzle");
    }
    public override void Attack()
    {
        GameObject clone = Instantiate(bullet,muzzle.position,muzzle.rotation);
        clone.transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
