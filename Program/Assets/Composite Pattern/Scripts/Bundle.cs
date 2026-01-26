using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Bundle : MonoBehaviour, IRewardable
{
    [SerializeField] List<IRewardable> rewardList = new List<IRewardable>();
    public List<IRewardable> RewardList { get { return rewardList; } }
    public void Add(IRewardable reward)
    {
        rewardList.Add(reward);
    }

    public void Receive()
    {
        foreach (IRewardable reward in rewardList)
            reward.Receive();
    }
}
