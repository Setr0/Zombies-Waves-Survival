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

    protected virtual void Awake()
    {
        life = GetComponent<Life>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        isEnabled = true;
    }

    protected virtual void OnEnable()
    {
        life.OnDied += Disable;
    }

    protected virtual void OnDisable()
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

        Flip();
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    protected virtual void Flip()
    {
        if (direction.x == 0) return;

        if (direction.x > 0) transform.localScale = new Vector3(1, 1, 1);
        if (direction.x < 0) transform.localScale = new Vector3(-1, 1, 1);
    }
}
