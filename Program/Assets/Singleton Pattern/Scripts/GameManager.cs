using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] bool state;

    public bool State
    {
        get { return state; }
        set { state = value; }
    }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<GameManager>();
            return instance;
        }
        
    }

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;
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
