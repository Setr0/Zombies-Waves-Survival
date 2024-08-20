using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class EnemyController : MonoBehaviour
{
    CharacterMovement characterMovement;

    Transform player;

    Vector2 direction;

    [SerializeField] float stopDistance = 1f;

    void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();

        player = GameObject.FindGameObjectWithTag("Player").transform;

        direction = Vector2.zero;
    }

    void Update()
    {
        if (Vector2.Distance(player.position, transform.position) > stopDistance)
        {
            FollowPlayer();
        }
        else
        {
            characterMovement.SetDirection(Vector2.zero);
        }
    }

    void FollowPlayer()
    {
        direction = (player.position - transform.position).normalized;

        characterMovement.SetDirection(direction);
    }
}
