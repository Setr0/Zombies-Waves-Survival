using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class PlayerWeaponHandler : MonoBehaviour
{
    public delegate void FlipHandler(bool isRight);
    public event FlipHandler OnFlipped;

    Camera mainCamera;

    public Weapon currentWeapon;
    [SerializeField] Transform weaponContainer;

    Vector2 mousePosition;
    Vector2 aimDirection;

    [SerializeField] float offset = 180f;

    void Start()
    {
        mainCamera = Camera.main;
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
        currentWeapon.SpawnBullet();
    }
}
