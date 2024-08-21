using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    public int damage = 1;
    public int pierce = 1;
    public Vector2 direction;

    void Update()
    {
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Disable();
    }

    public void Disable()
    {
        pierce--;

        if (pierce > 0) return;

        Destroy(gameObject);
    }
}
