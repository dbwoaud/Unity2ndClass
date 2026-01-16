using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float maxDistance = 20f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, startPos) >= maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
