using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] string bulletId = "PistolBullet";

    [Space(20)]
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
        if (!gameObject.activeSelf) return;

        Disable(true);
    }

    public void Disable(bool ignorePierce = false)
    {
        if (!ignorePierce)
        {
            pierce--;

            if (pierce > 0) return;
        }

        gameObject.SetActive(false);

        PoolManager.Instance.AddToPool(bulletId, gameObject);
    }
}
