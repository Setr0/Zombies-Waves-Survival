using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterMovement), typeof(PlayerWeaponHandler))]
public class InputManager : MonoBehaviour
{
    CharacterMovement characterMovement;
    PlayerWeaponHandler playerWeaponHandler;

    PlayerInputAction playerInputAction;

    void Awake()
    {
        playerInputAction = new PlayerInputAction();
    }

    void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();
        playerWeaponHandler = GetComponent<PlayerWeaponHandler>();
    }

    void OnEnable()
    {
        playerInputAction.Player.Enable();

        playerInputAction.Player.Move.performed += Move;
        playerInputAction.Player.Move.canceled += Move;

        playerInputAction.Player.Shoot.performed += Shoot;

        playerInputAction.Player.Reload.performed += Reload;
    }

    void OnDisable()
    {
        playerInputAction.Player.Disable();

        playerInputAction.Player.Move.performed -= Move;
        playerInputAction.Player.Move.canceled -= Move;

        playerInputAction.Player.Shoot.performed -= Shoot;

        playerInputAction.Player.Reload.performed -= Reload;
    }

    void Move(InputAction.CallbackContext context)
    {
        characterMovement.SetDirection(context.ReadValue<Vector2>());
    }

    void Shoot(InputAction.CallbackContext context)
    {
        playerWeaponHandler.Shoot();
    }

    void Reload(InputAction.CallbackContext context)
    {
        playerWeaponHandler.ReloadWeapon();
    }
}
