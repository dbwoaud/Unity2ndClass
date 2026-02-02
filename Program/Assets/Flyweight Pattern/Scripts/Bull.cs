using System.Collections;
using UnityEngine;

public class Bull : MonoBehaviour
{
    private Coroutine coroutine;

    [SerializeField] string[] patternName;
    [SerializeField] Animator animator;
    [SerializeField] AnimatorClipInfo[] animatorClipInfoList;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animatorClipInfoList = animator.GetCurrentAnimatorClipInfo(0);
    }
    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while(true)
        {
            yield return CoroutineCache.GetCachedWait(5.0f);
            if (coroutine != null)
                StopCoroutine(coroutine);
            coroutine = StartCoroutine(Pattern(patternName[Random.Range(0,patternName.Length)]));
        }
    }

    private IEnumerator Pattern(string name)
    {
        animator.SetTrigger(name);
        Debug.Log(animatorClipInfoList[0].clip.length);
        yield return CoroutineCache.GetCachedWait(animatorClipInfoList[0].clip.length);
    }
}
