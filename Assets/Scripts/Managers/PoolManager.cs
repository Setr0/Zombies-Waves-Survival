using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    public Pool[] pools;

    void Start()
    {
        foreach (Pool pool in pools)
        {
            GameObject newContainer = new GameObject($"{pool.id}Container");
            newContainer.transform.parent = transform;
            pool.container = newContainer.transform;

            for (int i = 0; i < pool.amount; i++)
            {
                GameObject newPrefab = Instantiate(pool.prefab, newContainer.transform);
                newPrefab.SetActive(false);
                pool.pooledObjects.Add(newPrefab);
            }
        }
    }

    public GameObject Instantiate(string id, Vector2 spawnPosition, Quaternion rotation = new Quaternion())
    {
        Pool pool = Array.Find(pools, pool => pool.id == id);
        GameObject randomPrefab;

        if (pool.pooledObjects.Count > 0)
        {
            randomPrefab = pool.pooledObjects[0];
            randomPrefab.transform.position = spawnPosition;

            pool.pooledObjects.RemoveAt(pool.pooledObjects.IndexOf(randomPrefab));
            randomPrefab.transform.rotation = rotation;
            randomPrefab.SetActive(true);
        }
        else
        {
            randomPrefab = Instantiate(pool.prefab, spawnPosition, rotation == new Quaternion() ? Quaternion.identity : rotation, pool.container == null ? transform : pool.container);
        }

        return randomPrefab;
    }

    public void AddToPool(string id, GameObject prefab)
    {
        Pool pool = Array.Find(pools, pool => pool.id == id);

        pool.pooledObjects.Add(prefab);
    }
}
