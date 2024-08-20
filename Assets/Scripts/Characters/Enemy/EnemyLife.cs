using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : CharacterLife
{
    public override void OnDeathComplete()
    {
        Destroy(gameObject);
    }
}