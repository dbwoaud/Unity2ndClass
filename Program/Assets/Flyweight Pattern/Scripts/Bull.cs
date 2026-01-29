using System.Collections;
using UnityEngine;

public class Bull : MonoBehaviour
{
    private Coroutine coroutine;
    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        coroutine = StartCoroutine(Smash());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(coroutine != null)
                StopCoroutine(coroutine);
            coroutine = StartCoroutine(Domination());
            
        }
    }
    private IEnumerator Smash()
    {
        animator.SetTrigger("Smash");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Smash Exit");
    }

    private IEnumerator Domination()
    {
        animator.SetTrigger("Domination");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Domination Exit");
    }

    private IEnumerator Yelling()
    {
        animator.SetTrigger("Yelling");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Yelling Exit");
    }
}
