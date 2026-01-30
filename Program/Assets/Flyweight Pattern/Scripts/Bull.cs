using System.Collections;
using UnityEngine;

public class Bull : MonoBehaviour
{
    private Coroutine coroutine;

    [SerializeField] Animator animator;
    [SerializeField] AnimatorClipInfo[] animatorClipInfoList;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animatorClipInfoList = animator.GetCurrentAnimatorClipInfo(0);
    }
    private void Start()
    {
        coroutine = StartCoroutine(Smash());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(coroutine != null)
                StopCoroutine(coroutine);
            coroutine = StartCoroutine(Smash());      
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (coroutine != null)
                StopCoroutine(coroutine);
            coroutine = StartCoroutine(Domination());
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (coroutine != null)
                StopCoroutine(coroutine);
            coroutine = StartCoroutine(Yelling());
        }
    }
    private IEnumerator Smash()
    {
        animator.SetTrigger("Smash");
        Debug.Log(animatorClipInfoList[0].clip.length);
        yield return CoroutineCache.GetCachedWait(animatorClipInfoList[0].clip.length);
    }

    private IEnumerator Domination()
    {
        animator.SetTrigger("Domination");
        Debug.Log(animatorClipInfoList[0].clip.length);
        yield return CoroutineCache.GetCachedWait(animatorClipInfoList[0].clip.length);
    }

    private IEnumerator Yelling()
    {
        animator.SetTrigger("Yelling");
        Debug.Log(animatorClipInfoList[0].clip.length);
        yield return CoroutineCache.GetCachedWait(animatorClipInfoList[0].clip.length);
    }
}
