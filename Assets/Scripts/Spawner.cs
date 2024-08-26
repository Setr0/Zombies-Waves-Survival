using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Spawner : MonoBehaviour
{
    [SerializeField] string[] ids;
    public int amount = 1;

    [Space(10)]
    [SerializeField] Vector2 distance = new Vector2(30f, 30f);

    [Space(10)]
    [SerializeField] Tilemap grassTilemap;
    [SerializeField] Tilemap waterTilemap;

    List<Vector2> grassTilesPositions;

    Transform player;
    Camera mainCamera;

    int attempts;
    int maxAttempts;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        mainCamera = Camera.main;

        attempts = 0;
        maxAttempts = 50;

        grassTilesPositions = new List<Vector2>();

        BoundsInt bounds = grassTilemap.cellBounds;

        foreach (Vector3Int position in bounds.allPositionsWithin)
        {
            if (grassTilemap.HasTile(position) && !waterTilemap.HasTile(position))
            {
                grassTilesPositions.Add((Vector2Int)position);
            }
        }
    }

    public void Spawn()
    {
        attempts = 0;
        for (int i = 0; i < amount; i++)
        {
            if (attempts > maxAttempts) break;

            List<Vector2> nearTiles = new List<Vector2>();
            foreach (Vector2 position in grassTilesPositions)
            {
                if (Vector2.Distance(position, player.position) < 30)
                {
                    nearTiles.Add(position);
                }
            }

            Vector2 randomPosition = nearTiles[Random.Range(0, nearTiles.Count)];
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
