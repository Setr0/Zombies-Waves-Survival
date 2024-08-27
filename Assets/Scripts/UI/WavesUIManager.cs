using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WavesUIManager : MonoBehaviour
{
    [SerializeField] WavesManager wavesManager;

    [Space(20)]
    [SerializeField] TextMeshProUGUI wavesText;
    [SerializeField] TextMeshProUGUI enemiesText;

    [Space(20)]
    [SerializeField] TextMeshProUGUI waveText;

    void OnEnable()
    {
        wavesManager.OnWaveStarted += UpdateWaves;
        wavesManager.OnUpdatedCurrentEnemies += UpdateEnemies;
    }

    void OnDisable()
    {
        wavesManager.OnWaveStarted -= UpdateWaves;
        wavesManager.OnUpdatedCurrentEnemies -= UpdateEnemies;
    }

    void UpdateWaves(int waves)
    {
        wavesText.text = $"WAVES: {waves}";

        waveText.text = $"WAVE {waves}";
        waveText.gameObject.SetActive(true);
    }

    void UpdateEnemies(int enemies)
    {
        enemiesText.text = $"ENEMIES: {enemies}";
    }
}
