using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    
    [SerializeField] bool state;

    public bool State
    {
        get { return state; }
        set { state = value; }
    }


    private void Start()
    {
        state = true;
    }
    public void OnClickPauseButton()
    {
        state = false;
    }

    public void OnClickContinueButton()
    {
        state = true;
    }

}
