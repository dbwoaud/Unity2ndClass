using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] GameObject portal;


    public void Init()
    {
        portal = GameObject.Find("Portal");
        transform.LookAt(portal.transform);
        direction = (portal.transform.position - transform.position).normalized;
    }
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Portal"))
        {
            ObjectPool.Instance.ReturnObject(gameObject);
        }
    }
}
