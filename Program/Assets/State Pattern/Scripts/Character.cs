using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator animator;
    [SerializeField] IStatable statable;
    private Attack attack;
    private Idle idle;
    private Walk walk;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        attack = new Attack();
        idle = new Idle();
        walk = new Walk();
    }
    void Start()
    {
        statable = idle;
    }

    // Update is called once per frame
    void Update()
    {
        statable.Stay(this);
        else
            SwitchState(idle);
    }

    public void SwitchState(IStatable state)
    {
        statable.Exit(this);
        statable = state;
        statable.Enter(this);
    }
}
