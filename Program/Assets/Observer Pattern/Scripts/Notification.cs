using UnityEngine;

public class Notification : MonoBehaviour
{
    private void OnEnable()
    {
        QuestManager.onQuestCompleted += Show;
    }

    private void OnDisable()
    {
        QuestManager.onQuestCompleted -= Show;
    }
    void Show(Quest quest)
    {
        Debug.Log("Quest Name: " + quest.title + " Clear");
    }
}
