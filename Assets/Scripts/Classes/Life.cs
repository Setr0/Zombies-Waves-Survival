using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Life : MonoBehaviour
{
    public delegate void LifeHandler(float health);
    public event LifeHandler OnDamaged;
    public event LifeHandler OnDied;


    public float health = 3f;
    [HideInInspector] public float maxHealth;

    [SerializeField] float hitDelay = 0.5f;

    protected bool isTakingHit;
    protected bool isDying;

    protected virtual void Awake()
    {
        maxHealth = health;

        isTakingHit = false;
        isDying = false;
    }

    public virtual void TakeDamage(float damage = 1)
    {
        if (isTakingHit || isDying) return;

        health -= damage;

        if (health > 0)
        {
            OnDamaged?.Invoke(health);

            Damaged();

            isTakingHit = true;
            StartCoroutine(TakeDamageDelay());
        }
        else
        {
            OnDied?.Invoke(health);

            Die();

            isDying = true;
        }
    }

    public abstract void Damaged();

    protected virtual IEnumerator TakeDamageDelay()
    {
        yield return new WaitForSeconds(hitDelay);

        isTakingHit = false;
    }

    public abstract void Die();

    public abstract void OnDeathComplete();
}
