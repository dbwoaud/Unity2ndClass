using System.Collections.Generic;
using UnityEngine;

public class CoroutineCache
{
    private static Dictionary<float,WaitForSeconds> skillCoolTime = new Dictionary<float,WaitForSeconds>();
    public static WaitForSeconds GetCachedWait(float time)
    {
        WaitForSeconds waitForSeconds = null;
        if(!skillCoolTime.TryGetValue(time, out waitForSeconds))
        {
            skillCoolTime.Add(time, new WaitForSeconds(time));
            waitForSeconds = skillCoolTime[time];
        }
        return waitForSeconds;
            
    }


}
