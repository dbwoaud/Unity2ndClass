using UnityEngine;

public class Eggy : MonoBehaviour
{
    [SerializeField] Vector3 axis = Vector3.up;
    [SerializeField] float angle = 45f;
    [SerializeField] float speed = 1f;

    Quaternion quaternion;
    void Start()
    {
        quaternion = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.State == true)
        {
            float time = Mathf.PingPong(Time.time * speed, 1f);
            float rotValue = (time * 2f - 1f) * angle;
            transform.localRotation = quaternion * Quaternion.AngleAxis(rotValue, axis);
        }
    }
}
