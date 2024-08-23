using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : CharacterLife
{
    public override void OnDeathComplete()
    {
        Destroy(gameObject);
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