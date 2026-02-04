using UnityEngine;
using UnityEngine.UI;
public class Notification : MonoBehaviour
{
    [SerializeField] Button acceptButton;
    [SerializeField] Sprite clearIcon;
    private void Awake()
    {
        acceptButton = GetComponentInChildren<Button>();
    }
    private void OnEnable()
    {
        QuestManager.OnQuestCompleted += Show;
    }

    private void OnDisable()
    {
        QuestManager.OnQuestCompleted -= Show;
    }
    void Show(Quest quest)
    {
        if(quest.complete)
        {
            acceptButton.gameObject.SetActive(true);
            acceptButton.image.sprite = clearIcon;
        }

    }
}
