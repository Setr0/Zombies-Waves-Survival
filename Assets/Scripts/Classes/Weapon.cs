using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponObject weaponObject;
    [SerializeField] Transform bulletSpawnPoint;

    Vector2 direction;

    bool canShoot;

    void Start()
    {
        canShoot = true;
    }

    public void SpawnBullet()
    {
        if (!canShoot) return;

        direction = ((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)bulletSpawnPoint.position).normalized;

        GameObject bullet = PoolManager.Instance.Instantiate("Bullet",
                                                    bulletSpawnPoint.position, GetRotation(bulletSpawnPoint.position, direction));
        bullet.GetComponent<Bullet>().direction = direction;
        bullet.GetComponent<Bullet>().damage = weaponObject.stats.damage;
        bullet.GetComponent<Bullet>().pierce = weaponObject.stats.pierce;

        canShoot = false;
        StartCoroutine(ShootDelay());
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(weaponObject.stats.fireRate);

        canShoot = true;
    }

    Quaternion GetRotation(Vector2 position, Vector2 direction)
    {
        Vector2 rotationDirection = (position + direction - position).normalized;
        float angle = Mathf.Atan2(rotationDirection.y, rotationDirection.x) * Mathf.Rad2Deg;
        return Quaternion.Euler(Vector3.forward * (angle - 90f));
    }
}
