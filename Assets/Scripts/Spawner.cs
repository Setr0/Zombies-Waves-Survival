using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] string[] ids;
    [SerializeField] float spawnTime = 3f;
    [SerializeField] int amount = 1;

    [Space(10)]
    [SerializeField] Vector2 distance = new Vector2(30f, 30f);

    Transform player;
    Camera mainCamera;

    int attempts;
    int maxAttempts;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        mainCamera = Camera.main;

        attempts = 0;
        maxAttempts = 50;

        InvokeRepeating(nameof(Spawn), spawnTime, spawnTime);
    }

    void Spawn()
    {
        attempts = 0;
        for (int i = 0; i < amount; i++)
        {
            if (attempts > maxAttempts) break;

            Vector2 randomPosition = (Vector2)player.position + new Vector2(Random.Range(-distance.x, distance.x), Random.Range(-distance.y, distance.y));
            Vector2 randomPositionToViewportPoint = mainCamera.WorldToViewportPoint(randomPosition);

            string randomId = ids[Random.Range(0, ids.Length)];

            if (randomPositionToViewportPoint.x < 0 || randomPositionToViewportPoint.x > 1
            || randomPositionToViewportPoint.y < 0 || randomPositionToViewportPoint.y > 1)
            {
                InstantiatePrefab(randomId, randomPosition);
            }
            else
            {
                i--;
                attempts++;
            }
        }
    }

    void InstantiatePrefab(string id, Vector2 spawnPosition)
    {
        PoolManager.Instance.Instantiate(id, spawnPosition);
    }
}
