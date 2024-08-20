using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D rb;

    Vector2 direction;

    [SerializeField] float speed = 6f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;

        if (direction.x == 0) return;

        if (direction.x > 0) transform.localScale = new Vector3(1, 1, 1);
        if (direction.x < 0) transform.localScale = new Vector3(-1, 1, 1);
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }
}
