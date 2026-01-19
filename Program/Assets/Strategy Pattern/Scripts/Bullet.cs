using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float duration;

    [SerializeField] Vector3 direction;

    private void Start()
    {
        Destroy(gameObject, duration);
    }
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
