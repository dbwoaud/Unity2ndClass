using UnityEngine;

public class Chili : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float distance = 2f;
    [SerializeField] Vector3 direction = Vector3.forward;

    [SerializeField] Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1f);
        transform.localPosition = initialPos + direction.normalized * distance * time;
    }
}
