using Unity.VisualScripting;
using UnityEngine;

public class RewardManager : MonoBehaviour
{
    [SerializeField] int createCount;
    [SerializeField] Bundle bundle;
    [SerializeField] Reward reward;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject parent;

    private void Awake()
    {
        createCount = Random.Range(1, 5);
    }
    private void Start()
    {
        for(int i = 0; i < createCount; i++)
        {
            bundle.Add(Instantiate(reward,parent.transform));
        }
    }

    public void OnClickAcceptButton()
    {
        bundle.Receive();
        panel.SetActive(false);
    }
}
