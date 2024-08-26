using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Life))]
public class EnemyDamageArea : MonoBehaviour
{
    EnemyLife enemyLife;

    [SerializeField] float damage = 1;
    [SerializeField] float damageDelay = 0.75f;

    [Space(20)]
    [SerializeField] float damageRadius = 0.5f;
    [SerializeField] LayerMask playerLayer;

    Collider2D player;

    bool isEnabled;
    bool canDamage;

    void Awake()
    {
        enemyLife = GetComponent<EnemyLife>();
    }

    void Start()
    {
        isEnabled = true;
        canDamage = true;
    }

    void OnEnable()
    {
        enemyLife.OnDied += Disable;
        enemyLife.OnRestored += Enable;
    }

    void OnDisable()
    {
        enemyLife.OnDied -= Disable;
        enemyLife.OnRestored -= Enable;
    }

    void Disable()
    {
        isEnabled = false;
    }

    void Enable()
    {
        isEnabled = true;
    }

    void Update()
    {
        if (!isEnabled || !canDamage) return;

        player = Physics2D.OverlapCircle(transform.position, damageRadius, playerLayer);

        if (player != null)
        {
            player.GetComponent<PlayerLife>().TakeDamage(damage);

            canDamage = false;
            StartCoroutine(DamageDelay());
        }
    }

    IEnumerator DamageDelay()
    {
        yield return new WaitForSeconds(damageDelay);

        canDamage = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, damageRadius);
    }
}
