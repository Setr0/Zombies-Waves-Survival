using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : CharacterLife
{
    [SerializeField] string id;
    [SerializeField] string[] dropIds;

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
        animator.SetTrigger("Restore");

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