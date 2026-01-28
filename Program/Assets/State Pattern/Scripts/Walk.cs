using UnityEngine;

public class Walk : IStatable
{
    public void Enter(Character character)
    {
        character.animator.SetInteger("X", 1);
        character.animator.SetInteger("Y", 1);
    }
    public void Stay(Character character)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            character.SwitchState(new Attack());
        }

        int X = (int)Input.GetAxisRaw("Horizontal");
        int Y = (int)Input.GetAxisRaw("Vertical");
        if (X == 0 && Y == 0)
            character.SwitchState(new Idle());
    }
    public void Exit(Character character)
    {
        character.animator.SetInteger("X", 0);
        character.animator.SetInteger("Y", 0);
    }
}
