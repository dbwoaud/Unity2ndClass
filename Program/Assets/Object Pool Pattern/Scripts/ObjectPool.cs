using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;
    public static ObjectPool Instance { get { return instance; } }
    [SerializeField] Stack<GameObject> monsterStack = new Stack<GameObject>();
    [SerializeField] int spawnCount;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            if(instance == null)
                instance = new GameObject("ObjectPool").AddComponent<ObjectPool>();
        }
        else
            Destroy(gameObject);
        
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
