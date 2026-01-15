using UnityEngine;

public class Grenade : Weapon
{
    public override void Attack()
    {
        Debug.Log("수류탄으로 공격");
    }
}
