using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : CharacterLife
{
    public event LifeHandler OnTookHealth;

    [SerializeField] WavesManager wavesManager;

    void OnEnable()
    {
        wavesManager.OnWaveStarted += RestoreHealth;
    }

    void OnDisable()
    {
        wavesManager.OnWaveStarted -= RestoreHealth;
    }

    void RestoreHealth(int waves)
    {
        TakeHealth(maxHealth);
    }

    public void TakeHealth(float health)
    {
        if (this.health + health > maxHealth)
        {
            this.health = maxHealth;
        }
        else
        {
            this.health += health;
        }

        OnTookHealth?.Invoke(health);
    }

    public override void OnDeathComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}