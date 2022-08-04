using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePooler : MonoBehaviour
{
    private List<GameObject> pooledObjects;
    private int amountToPool = 3;
    private Vector3 startPosition;
    public GameObject objectToPool;
    public float maxTime = 3f;
    public float height = 1f;

    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for(int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool, transform);
            startPosition = tmp.transform.position;
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
        InvokeRepeating("EnableObject", 0f, maxTime);
    }

    public GameObject GetPooledObject()
    {
        for(int i = 0; i < amountToPool; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

    void EnableObject()
    {
        GameObject tmp = GetPooledObject();
        if(tmp != null)
        {
            tmp.transform.position = startPosition + new Vector3(0, Random.Range(-height, height), 0);
            tmp.SetActive(true);
        }
    }
}