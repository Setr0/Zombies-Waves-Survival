using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : CharacterLife
{
    public delegate void EnemyLifeHandler();
    public event EnemyLifeHandler OnRestored;

    [SerializeField] string id;
    [SerializeField] string[] dropIds;

    void OnEnable()
    {
        health = maxHealth;
    }

    public override void Damaged()
    {
        base.Damaged();

        if (Crosshair.Instance != null) Crosshair.Instance.SetHitted();
    }

    public override void Die()
    {
        base.Die();

        if (Crosshair.Instance != null) Crosshair.Instance.SetKilled();
    }

    public override void OnDeathComplete()
    {
        if (WavesManager.Instance != null) WavesManager.Instance.UpdateWaveState();

        animator.SetTrigger("Restore");
        isTakingHit = false;
        isDying = false;

        OnRestored?.Invoke();

        PoolManager.Instance.Instantiate(dropIds[Random.Range(0, dropIds.Length)], transform.position, Quaternion.identity);

        gameObject.SetActive(false);

        PoolManager.Instance.AddToPool(id, gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(collision.GetComponent<Bullet>().damage);
            collision.GetComponent<Bullet>().Disable();
        }
    }
}