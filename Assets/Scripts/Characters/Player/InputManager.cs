using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterMovement), typeof(PlayerWeaponHandler))]
public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    CharacterMovement characterMovement;
    PlayerWeaponHandler playerWeaponHandler;
    PlayerWeaponInventory playerWeaponInventory;

    public PlayerInputAction playerInputAction;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }

        playerInputAction = new PlayerInputAction();
    }

    void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();
        playerWeaponHandler = GetComponent<PlayerWeaponHandler>();
        playerWeaponInventory = GetComponent<PlayerWeaponInventory>();
    }

    void OnEnable()
    {
        playerInputAction.Player.Enable();

        playerInputAction.Player.Move.performed += Move;
        playerInputAction.Player.Move.canceled += Move;

        playerInputAction.Player.Shoot.performed += Fire;
        playerInputAction.Player.Shoot.canceled += DontFire;

        playerInputAction.Player.Aim.performed += Aim;
        playerInputAction.Player.Aim.canceled += Aim;

        playerInputAction.Player.Reload.performed += Reload;

        playerInputAction.Player.SelectSpace1.performed += SelectSpace1;
        playerInputAction.Player.SelectSpace2.performed += SelectSpace2;
        playerInputAction.Player.SelectSpace3.performed += SelectSpace3;
        playerInputAction.Player.SelectSpace4.performed += SelectSpace4;
        playerInputAction.Player.SelectSpace5.performed += SelectSpace5;
        playerInputAction.Player.SelectSpace6.performed += SelectSpace6;
        playerInputAction.Player.SelectSpace7.performed += SelectSpace7;
        playerInputAction.Player.SelectSpace8.performed += SelectSpace8;
    }

    void OnDisable()
    {
        playerInputAction.Player.Disable();

        playerInputAction.Player.Move.performed -= Move;
        playerInputAction.Player.Move.canceled -= Move;

        playerInputAction.Player.Shoot.performed -= Fire;
        playerInputAction.Player.Shoot.canceled -= DontFire;

        playerInputAction.Player.Aim.performed -= Aim;
        playerInputAction.Player.Aim.canceled -= Aim;

        playerInputAction.Player.Reload.performed -= Reload;

        playerInputAction.Player.SelectSpace1.performed -= SelectSpace1;
        playerInputAction.Player.SelectSpace2.performed -= SelectSpace2;
        playerInputAction.Player.SelectSpace3.performed -= SelectSpace3;
        playerInputAction.Player.SelectSpace4.performed -= SelectSpace4;
        playerInputAction.Player.SelectSpace5.performed -= SelectSpace5;
        playerInputAction.Player.SelectSpace6.performed -= SelectSpace6;
        playerInputAction.Player.SelectSpace7.performed -= SelectSpace7;
        playerInputAction.Player.SelectSpace8.performed -= SelectSpace8;
    }

    void Move(InputAction.CallbackContext context)
    {
        characterMovement.SetDirection(context.ReadValue<Vector2>());
    }

    void Fire(InputAction.CallbackContext context)
    {
        playerWeaponHandler.SetIsFiring(true);
    }

    void DontFire(InputAction.CallbackContext context)
    {
        playerWeaponHandler.SetIsFiring(false);
    }

    void Aim(InputAction.CallbackContext context)
    {
        playerWeaponHandler.SetAiming(context.ReadValue<Vector2>());
    }

    void Reload(InputAction.CallbackContext context)
    {
        StartCoroutine(playerWeaponHandler.ReloadWeapon());
    }

    #region Weapon selection
    void SelectSpace1(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(1);
    }

    void SelectSpace2(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(2);
    }

    void SelectSpace3(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(3);
    }

    void SelectSpace4(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(4);
    }

    void SelectSpace5(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(5);
    }

    void SelectSpace6(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(6);
    }

    void SelectSpace7(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(7);
    }

    void SelectSpace8(InputAction.CallbackContext context)
    {
        playerWeaponInventory.SelectWeapon(8);
    }
    #endregion
}
