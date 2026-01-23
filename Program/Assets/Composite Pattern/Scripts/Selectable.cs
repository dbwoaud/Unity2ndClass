using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Selectable : MonoBehaviour
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] Vector3 size = new Vector3(0.75f, 0.75f, 0.75f);

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void Deselect()
    {
        rectTransform.localScale = Vector3.one;
    }

    public void Select()
    {
        rectTransform.localScale = size;
    }

}
