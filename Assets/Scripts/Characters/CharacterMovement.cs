using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Life))]
public class CharacterMovement : MonoBehaviour
{
    Life life;

    Rigidbody2D rb;

    Vector2 direction;

    [SerializeField] float speed = 6f;

    bool isEnabled;

    void Awake()
    {
        life = GetComponent<Life>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        isEnabled = true;
    }

    void OnEnable()
    {
        life.OnDied += Disable;
    }

    void OnDisable()
    {
        life.OnDied -= Disable;
    }

    void Disable()
    {
        isEnabled = false;
    }

    void FixedUpdate()
    {
        if (!isEnabled)
        {
            rb.velocity = Vector2.zero;

            return;
        }

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
