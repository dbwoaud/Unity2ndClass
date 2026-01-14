using UnityEngine;

public class Kiwi : MonoBehaviour
{
    [SerializeField] float maxScale = 5f;
    [SerializeField] float speed = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.State == true)
        {
            float scaleValue = Mathf.PingPong(Time.time * speed, maxScale);
            transform.localScale = Vector3.one * scaleValue;
        }
    }
}
