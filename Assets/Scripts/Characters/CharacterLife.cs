using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLife : Life
{
    SpriteRenderer spriteRenderer;
    Animator animator;

    protected override void Start()
    {
        base.Start();

        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public override void Damaged()
    {
        spriteRenderer.color = Color.red;
    }

    protected override IEnumerator TakeDamageDelay()
    {
        yield return StartCoroutine(base.TakeDamageDelay());

        spriteRenderer.color = Color.white;
    }

    public override void Die()
    {
        animator.SetTrigger("Death");
    }
}