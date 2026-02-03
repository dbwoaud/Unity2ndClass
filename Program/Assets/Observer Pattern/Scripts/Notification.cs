using UnityEngine;
using UnityEngine.UI;
public class Notification : MonoBehaviour
{
    [SerializeField] Button acceptButton;

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
        Debug.Log("Quest Name: " + quest.title + " Clear");
    }
}
