using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject portal;
    [SerializeField] GameObject monster;
    [SerializeField] float distance = 10f;
    [SerializeField] WaitForSeconds duration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        portal = GameObject.Find("Portal");
        duration = new WaitForSeconds(5.0f);
    }
    void Start()
    {
        StartCoroutine(CreateCoroutine());
    }

    IEnumerator CreateCoroutine()
    {
        while(true)
        {
            GameObject clone = Instantiate(monster);
            Vector2 direction = Random.insideUnitCircle.normalized * distance;
            clone.transform.position = new Vector3(direction.x, 0, direction.y);
            yield return duration;
        }
    }

}
