using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pool
{
    public string id;
    public GameObject prefab;
    public List<GameObject> pooledObjects = new List<GameObject>();
    public int amount = 1;
    [HideInInspector] public Transform container;
}