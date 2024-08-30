using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class PlayerWeaponHandler : MonoBehaviour
{
    public delegate void FlipHandler(bool isRight);
    public event FlipHandler OnFlipped;

    public delegate void AmmosHandler(int ammos, int ammosInUse);
    public event AmmosHandler OnAmmosChanged;

    public delegate void ReloadHandler(bool isReloading);
    public event ReloadHandler OnReloadingChanged;

    Camera mainCamera;

    public Weapon currentWeapon;
    [SerializeField] Transform weaponContainer;

    Vector2 mousePosition;
    Vector2 aimDirection;

    [SerializeField] float offset = 180f;

    bool isReloading;

    public bool canFire;
    bool isFiring;

    void Start()
    {
        mainCamera = Camera.main;

        currentWeapon.weaponObject.stats.ammos = currentWeapon.weaponObject.stats.defaultAmmos;
        currentWeapon.weaponObject.stats.ammosInUse = currentWeapon.weaponObject.stats.maxAmmosInUse;

        AmmosChanged();

        isReloading = false;
        isFiring = false;
        canFire = true;
    }

    void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Rotate();

        if (isFiring && !isReloading) Shoot();
    }

    void Rotate()
    {
        aimDirection = mousePosition - (Vector2)weaponContainer.position;

        Vector2 rotationDirection = ((Vector2)weaponContainer.position - (aimDirection + (Vector2)weaponContainer.position)).normalized;
        float angle = Mathf.Atan2(rotationDirection.y, rotationDirection.x) * Mathf.Rad2Deg;
        weaponContainer.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));

        if (Mathf.Abs(mousePosition.x - weaponContainer.position.x) > 0.25f)
        {
            if (mousePosition.x < weaponContainer.position.x)
            {
                weaponContainer.localScale = new Vector3(-1, -1, 1);

                OnFlipped?.Invoke(false);
            }
            else
            {
                weaponContainer.localScale = new Vector3(1, 1, 1);

                OnFlipped?.Invoke(true);
            }
        }
    }

    public void SetIsFiring(bool isFiring)
    {
        if (!canFire) return;

        this.isFiring = isFiring;
    }

    void Shoot()
    {
        if (currentWeapon.weaponObject.stats.ammosInUse <= 0 || !currentWeapon.canShoot || isReloading) return;

        currentWeapon.SpawnBullet();

        currentWeapon.weaponObject.stats.ammosInUse--;

        AmmosChanged();

        if (currentWeapon.weaponObject.stats.ammosInUse <= 0)
        {
            canFire = false;
            isFiring = false;
            StartCoroutine(ReloadWeapon());
        }
    }

    public IEnumerator ReloadWeapon()
    {
        if (currentWeapon.weaponObject.stats.ammos <= 0 || currentWeapon.weaponObject.stats.ammosInUse >= currentWeapon.weaponObject.stats.maxAmmosInUse || isFiring || isReloading) yield break;

        isReloading = true;
        OnReloadingChanged?.Invoke(true);

        int neededAmmos = currentWeapon.weaponObject.stats.maxAmmosInUse - currentWeapon.weaponObject.stats.ammosInUse;

        if (neededAmmos < currentWeapon.weaponObject.stats.ammos)
        {
            currentWeapon.weaponObject.stats.ammosInUse += neededAmmos;

            currentWeapon.weaponObject.stats.ammos -= neededAmmos;
        }
        else
        {
            currentWeapon.weaponObject.stats.ammosInUse += currentWeapon.weaponObject.stats.ammos;

            currentWeapon.weaponObject.stats.ammos = 0;
        }

        yield return new WaitForSeconds(currentWeapon.weaponObject.stats.realoadTime);

        AmmosChanged();

        isReloading = false;
        canFire = true;
        OnReloadingChanged?.Invoke(false);
    }

    public void AddAmmos(int ammos)
    {
        currentWeapon.weaponObject.stats.ammos += ammos;

        AmmosChanged();
    }

    public void AmmosChanged()
    {
        OnAmmosChanged?.Invoke(currentWeapon.weaponObject.stats.ammos, currentWeapon.weaponObject.stats.ammosInUse);
    }
}
