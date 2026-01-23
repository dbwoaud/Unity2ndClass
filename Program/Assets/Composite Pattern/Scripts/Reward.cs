using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Reward : MonoBehaviour
{

    [SerializeField] List<Data> data;
    [SerializeField] string name;
    [SerializeField] Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        int randomIndex = Random.Range(0, data.Count);
        image.sprite = data[randomIndex].Sprite;
        gameObject.name = data[randomIndex].Name;
        name = data[randomIndex].Name;
    }
}
