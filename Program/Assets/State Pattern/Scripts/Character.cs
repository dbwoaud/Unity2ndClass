using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator animator;
    [SerializeField] IStatable statable;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
    void Start()
    {
        statable = new Idle();
    }

    // Update is called once per frame
    void Update()
    {
        statable.Stay(this);
    }

    public void SwitchState(IStatable state)
    {
        statable?.Exit(this);
        statable = state;
        statable?.Enter(this);
    }
}
