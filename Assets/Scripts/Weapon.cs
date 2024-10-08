using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Animator animator;
    Camera mainCamera;

    public string id = "Pistol";

    [Space(20)]
    public WeaponObject weaponObject;
    public SpriteRenderer spriteRenderer;
    [SerializeField] string bulletId = "Bullet";
    [SerializeField] Transform bulletSpawnPoint;
    [SerializeField] Transform distancePoint;
    [SerializeField] GameObject muzzleFlash;
    [SerializeField] GameObject trace;

    Vector2 direction;

    public bool canShoot;

    void Start()
    {
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;

        weaponObject.stats.ammos = weaponObject.stats.defaultAmmos;
        weaponObject.stats.ammosInUse = weaponObject.stats.maxAmmosInUse;
    }

    void OnEnable()
    {
        canShoot = true;
        muzzleFlash.SetActive(false);
    }

    public void SpawnBullet()
    {
        if (!canShoot) return;

        if (!MobileCommands.areEnabled)
            direction = ((Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition) - (Vector2)bulletSpawnPoint.position).normalized;
        else
            direction = ((Vector2)distancePoint.position - (Vector2)bulletSpawnPoint.position).normalized;

        GameObject bullet = PoolManager.Instance.Instantiate(bulletId,
                                                    bulletSpawnPoint.position, GetRotation(bulletSpawnPoint.position, direction));
        bullet.GetComponent<Bullet>().direction = direction;
        bullet.GetComponent<Bullet>().damage = weaponObject.stats.damage;
        bullet.GetComponent<Bullet>().pierce = weaponObject.stats.pierce;

        muzzleFlash.SetActive(true);

        animator.SetTrigger("Shoot");

        AudioManager.Instance.PlaySound("Shot");

        canShoot = false;
        StartCoroutine(ShootDelay());
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(0.1f);

        muzzleFlash.SetActive(false);

        yield return new WaitForSeconds(weaponObject.stats.fireRate);

        canShoot = true;
    }

    Quaternion GetRotation(Vector2 position, Vector2 direction)
    {
        Vector2 rotationDirection = (position + direction - position).normalized;
        float angle = Mathf.Atan2(rotationDirection.y, rotationDirection.x) * Mathf.Rad2Deg;
        return Quaternion.Euler(Vector3.forward * (angle - 90f));
    }

    public void EnableTrace(bool isEnabled)
    {
        trace.SetActive(isEnabled);
    }
}
