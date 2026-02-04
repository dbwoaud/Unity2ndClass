using System.Collections.Generic;
using System;
using UnityEngine;

public class QuestManager : Singleton<QuestManager>
{
    [SerializeField] List<Quest> questList = new List<Quest>();
    public static event Action<Quest> OnQuestCompleted;
    
    public void Accept(Quest quest)
    {
        if (quest == null || questList.Contains(quest))
            return;
        questList.Add(quest);
    }

    public void Complete(string questName)
    {
        Quest quest = questList.Find(mission => mission.title == questName);
        if (quest == null)
            return;

        quest.complete = true;
        OnQuestCompleted?.Invoke(quest);
    }
}
