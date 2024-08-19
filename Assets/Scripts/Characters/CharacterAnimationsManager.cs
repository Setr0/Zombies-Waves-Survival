using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationsManager : AnimationsManager
{
    Rigidbody2D rb;

    protected override void Start()
    {
        base.Start();

        rb = GetComponent<Rigidbody2D>();
    }

    protected override void HandleAnimations()
    {
        animator.SetBool("IsWalking", rb.velocity.sqrMagnitude > 0.01f);
    }
}
