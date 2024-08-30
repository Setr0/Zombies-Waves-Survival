using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesManager : MonoBehaviour
{
    public static WavesManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    public delegate void WavesHandler(int waves);
    public event WavesHandler OnWaveStarted;

    public delegate void EnemiesHandler(int enemies);
    public event EnemiesHandler OnUpdatedCurrentEnemies;

    [SerializeField] EnemySpawner enemySpawner;

    [SerializeField] int enemiesInWave = 10;
    int currentEnemiesInWave;
    [SerializeField] int incrementEnemiesInWave = 5;

    int waves;

    IEnumerator Start()
    {
        currentEnemiesInWave = 0;
        waves = 0;

        yield return new WaitForSeconds(3f);

        StartNewWave();
    }

    void StartNewWave()
    {
        waves++;
        currentEnemiesInWave = enemiesInWave;

        enemySpawner.amount = currentEnemiesInWave;

        if (waves % 2 == 0) enemySpawner.health += 3;

        enemySpawner.Spawn();

        OnWaveStarted?.Invoke(waves);
        OnUpdatedCurrentEnemies?.Invoke(currentEnemiesInWave);
    }

    public void UpdateWaveState()
    {
        currentEnemiesInWave--;

        OnUpdatedCurrentEnemies?.Invoke(currentEnemiesInWave);

        if (currentEnemiesInWave <= 0)
        {
            enemiesInWave += incrementEnemiesInWave;

            StartNewWave();
        }
    }
}
