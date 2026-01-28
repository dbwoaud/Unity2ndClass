using UnityEngine;

public class Idle : IStatable
{
    public void Enter(Character character)
    {
        Debug.Log("Idle Enter");
    }
    public void Stay(Character character)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            character.SwitchState(new Attack());
        }

        int X = (int)Input.GetAxisRaw("Horizontal");
        int Y = (int)Input.GetAxisRaw("Vertical");
        if(X != 0 || Y != 0)
            character.SwitchState(new Walk());
        Debug.Log("Idle Stay");
    }
    public void Exit(Character character)
    {
        Debug.Log("Idle Exit");
    }
}
