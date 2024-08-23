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

    Camera mainCamera;

    public Weapon currentWeapon;
    [SerializeField] Transform weaponContainer;

    Vector2 mousePosition;
    Vector2 aimDirection;

    [SerializeField] float offset = 180f;

    [Space(20)]
    [SerializeField] int ammos = 99;
    [SerializeField] int ammosInUse = 10;
    int maxAmmosInUse;

    void Start()
    {
        mainCamera = Camera.main;

        maxAmmosInUse = ammosInUse;

        OnAmmosChanged?.Invoke(ammos, ammosInUse);
    }

    void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Rotate();
    }

    void Rotate()
    {
        aimDirection = mousePosition - (Vector2)weaponContainer.position;

        Vector2 rotationDirection = ((Vector2)weaponContainer.position - (aimDirection + (Vector2)weaponContainer.position)).normalized;
        float angle = Mathf.Atan2(rotationDirection.y, rotationDirection.x) * Mathf.Rad2Deg;
        weaponContainer.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));

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

    public void Shoot()
    {
        if (ammosInUse <= 0 || !currentWeapon.canShoot) return;

        currentWeapon.SpawnBullet();

        ammosInUse--;

        OnAmmosChanged?.Invoke(ammos, ammosInUse);

        if (ammosInUse <= 0) ReloadWeapon();
    }

    public void ReloadWeapon()
    {
        if (ammos <= 0) return;

        int neededAmmos = maxAmmosInUse - ammosInUse;

        if (maxAmmosInUse >= neededAmmos)
        {
            ammosInUse += neededAmmos;

            ammos -= neededAmmos;
        }
        else
        {
            ammosInUse = ammos;

            ammos = 0;
        }

        OnAmmosChanged?.Invoke(ammos, ammosInUse);
    }
}
