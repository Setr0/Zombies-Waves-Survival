using UnityEngine;

public class AmmosSack : Item
{
    SpriteRenderer spriteRenderer;
    Animator animator;

    [SerializeField] string id = "AmmosSack";
    [SerializeField] int ammos = 5;

    protected override void Start()
    {
        base.Start();

        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    protected override void PickUp(Collider2D collision)
    {
        collision.GetComponent<PlayerWeaponHandler>().AddAmmos(ammos);

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