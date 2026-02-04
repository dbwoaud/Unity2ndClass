using UnityEngine;

public class PerformanceManager : MonoBehaviour
{
    [SerializeField] string[] questTitle;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            QuestManager.Instance.Complete(questTitle[Random.Range(0, questTitle.Length)]);
    }
}
