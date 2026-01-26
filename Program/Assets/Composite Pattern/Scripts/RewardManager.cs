using Unity.VisualScripting;
using UnityEngine;

public class RewardManager : MonoBehaviour
{
    [SerializeField] int createCount;
    [SerializeField] Bundle bundle;
    [SerializeField] Reward reward;
    [SerializeField] GameObject rewardList;

    private void Awake()
    {
        createCount = Random.Range(1, 5);
    }
    private void Start()
    {
        for(int i = 0; i < createCount; i++)
        {
            bundle.Add(Instantiate(reward));
        }
    }

    public void OnClickAcceptButton()
    {
        bundle.Receive();
        gameObject.SetActive(false);
    }
}
