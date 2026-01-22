using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Singleton<ObjectPool>
{
    [SerializeField] Stack<GameObject> monsterStack = new Stack<GameObject>();
    [SerializeField] int spawnCount;
    private void Awake()
    {
        spawnCount = 5;
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject clone = Instantiate(Resources.Load<GameObject>("minotaur"), transform);
            clone.SetActive(false);
            monsterStack.Push(clone);
        }
    }

    public GameObject GetObject()
    {
        GameObject clone = null;
        if(monsterStack.Count > 0)
        {
            clone = monsterStack.Pop();
        }
        else
        {
            monsterStack.Push(Instantiate(Resources.Load<GameObject>("minotaur"), transform));
            clone = monsterStack.Pop(); 
        }
        clone.SetActive(true);
        return clone;
    }

    public void ReturnObject(GameObject clone)
    {
        clone.SetActive(false);
        monsterStack.Push(clone);
    }
}
