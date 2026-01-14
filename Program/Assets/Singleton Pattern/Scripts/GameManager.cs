using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameManager instance;
    [SerializeField] bool state;

    private void Awake()
    {
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
}
