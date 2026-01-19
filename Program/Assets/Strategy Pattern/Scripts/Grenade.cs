using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class Grenade : Weapon
{
    [SerializeField] Vector3 throwDirection;
    [SerializeField] Vector3 startPos;
    [SerializeField] float throwSpeed;
    [SerializeField] Rigidbody rigidbody;

    private bool isThrowing;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        startPos = rigidbody.position;
        rigidbody.useGravity = false;
    }
    public override void Attack()
    {
        if(!isThrowing)
        {
            isThrowing = true;
            rigidbody.useGravity = true;
            rigidbody.AddForce(throwDirection.normalized * throwSpeed, ForceMode.Impulse);
        }

    }

    private void OnBecameInvisible()
    {
        isThrowing = false;
        rigidbody.useGravity = false;
        rigidbody.linearVelocity = Vector3.zero;
        transform.position = startPos;
        
    }
}
 