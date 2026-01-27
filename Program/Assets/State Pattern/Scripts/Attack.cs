using UnityEngine;

public class Attack : IStatable
{
    public void Enter(Character character)
    {
        Debug.Log("Attack Enter");
    }
    public void Stay(Character character)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            character.SwitchState(new Attack());
        }
        Debug.Log("Attack Stay");
    }
    public void Exit(Character character)
    {
        Debug.Log("Attack Exit");
    }
}
