using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    PlayerWeaponHandler playerWeaponHandler;

    protected override void Awake()
    {
        base.Awake();

        playerWeaponHandler = GetComponent<PlayerWeaponHandler>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        playerWeaponHandler.OnFlipped += Flip;
    }

    protected override void OnDisable()
    {
        base.OnDisable();

        playerWeaponHandler.OnFlipped -= Flip;
    }

    void Flip(bool isRight)
    {
        if (isRight) transform.localScale = new Vector3(1, 1, 1);
        else transform.localScale = new Vector3(-1, 1, 1);
    }

    protected override void Flip() { }
}