using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterMovement))]
public class InputManager : MonoBehaviour
{
    CharacterMovement characterMovement;

    PlayerInputAction playerInputAction;

    void Awake()
    {
        playerInputAction = new PlayerInputAction();
    }

    void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    void OnEnable()
    {
        playerInputAction.Player.Enable();

        playerInputAction.Player.Move.performed += Move;
        playerInputAction.Player.Move.canceled += Move;
    }

    void OnDisable()
    {
        playerInputAction.Player.Disable();

        playerInputAction.Player.Move.performed -= Move;
        playerInputAction.Player.Move.canceled -= Move;
    }

    void Move(InputAction.CallbackContext context)
    {
        characterMovement.SetDirection(context.ReadValue<Vector2>());
    }
}
