using UnityEngine;
using UnityEngine.UI;
public class Guide : MonoBehaviour
{
    [SerializeField] Quest quest;
    [SerializeField] Button acceptButton;

    private void Awake()
    {
        acceptButton = GetComponentInChildren<Button>();
    }
    public void Accept()
    {
        QuestManager.Instance.Accept(quest);
        acceptButton.gameObject.SetActive(false);
    }

}
