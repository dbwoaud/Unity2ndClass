using UnityEngine;

public class Attack : IStatable
{
    public void Enter(Character character)
    {
        character.animator.ResetTrigger("Attack");
        character.animator.SetTrigger("Attack");
    }
    public void Stay(Character character)
    {
        AnimatorStateInfo animatorStateInfo = character.animator.GetCurrentAnimatorStateInfo(0);
        if (character.animator.IsInTransition(0) && animatorStateInfo.IsName("Attack"))
            character.SwitchState(new Idle());
    }
    public void Exit(Character character)
    {
        character.animator.SetInteger("X", 0);
        character.animator.SetInteger("Y", 0);
    }
}
