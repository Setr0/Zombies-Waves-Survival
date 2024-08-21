using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class PlayerWeaponHandler : MonoBehaviour
{
    CharacterMovement characterMovement;

    Camera mainCamera;

    public Weapon currentWeapon;
    [SerializeField] Transform weaponContainer;

    Vector2 mousePosition;
    Vector2 aimDirection;

    [SerializeField] float offset = 180f;

    void Awake()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnEnable()
    {
        characterMovement.OnFlipped += FlipX;
    }

    void OnDisable()
    {
        characterMovement.OnFlipped -= FlipX;
    }

    void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Rotate();
    }

    void FlipX(float scale)
    {
        if (scale < 0) weaponContainer.localScale = new Vector3(-1, weaponContainer.localScale.y, 1);
        else weaponContainer.localScale = new Vector3(1, weaponContainer.localScale.y, 1);
    }

    void Rotate()
    {
        aimDirection = mousePosition - (Vector2)weaponContainer.position;

        Vector2 rotationDirection = ((Vector2)weaponContainer.position - (aimDirection + (Vector2)weaponContainer.position)).normalized;
        float angle = Mathf.Atan2(rotationDirection.y, rotationDirection.x) * Mathf.Rad2Deg;
        weaponContainer.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));

        if (mousePosition.x < weaponContainer.position.x)
        {
            weaponContainer.localScale = new Vector3(weaponContainer.localScale.x, -1, 1);
        }
        else
        {
            weaponContainer.localScale = new Vector3(weaponContainer.localScale.x, 1, 1);
        }
    }

    public void Shoot()
    {
        currentWeapon.SpawnBullet();
    }
}
