using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : Item
{
    SpriteRenderer spriteRenderer;
    Animator animator;

    [SerializeField] string id = "WeaponItem";
    [SerializeField] Weapon weapon;

    protected override void Start()
    {
        base.Start();

        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    protected override void PickUp(Collider2D collision)
    {
        if (collision.GetComponent<PlayerWeaponInventory>().IsInPosses(weapon.id)) return;

        collision.GetComponent<PlayerWeaponInventory>().AddWeapon(weapon);

        isPickingUp = true;

        AudioManager.Instance.PlaySound("PickUpItem");

        animator.SetTrigger("Feedback");
    }

    public override void OnPickUpCompleted()
    {
        animator.SetTrigger("Restore");
        spriteRenderer.sprite = null;

        gameObject.SetActive(false);

        PoolManager.Instance.AddToPool(id, gameObject);

        isPickingUp = false;
    }
}
