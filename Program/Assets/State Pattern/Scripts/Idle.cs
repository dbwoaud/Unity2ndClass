using UnityEngine;

public class Idle : IStatable
{
    public void Enter(Character character)
    {
        //character.animator.SetInteger("X", (int)Input.GetAxisRaw("Horizontal"));
        //character.animator.SetInteger("Y", (int)Input.GetAxisRaw("Vertical"));
        Debug.Log("Idle Enter");
    }
    public void Stay(Character character)
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
            character.SwitchState(new Idle());
        Debug.Log("Idle Stay");
    }
    public void Exit(Character character)
    {
        Debug.Log("Idle Exit");
    }
}
