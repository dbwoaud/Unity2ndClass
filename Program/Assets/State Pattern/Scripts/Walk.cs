using UnityEngine;

public class Walk : IStatable
{
    public void Enter(Character character)
    {
        //character.animator.SetInteger("X", (int)Input.GetAxisRaw("Horizontal"));
        //character.animator.SetInteger("Y", (int)Input.GetAxisRaw("Vertical"));
        Debug.Log("Walk Enter");
    }
    public void Stay(Character character)
    {
        Debug.Log("Walk Stay");
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            character.SwitchState(new Walk());
        }
    }
    public void Exit(Character character)
    {
        Debug.Log("Walk Exit");
    }
}
