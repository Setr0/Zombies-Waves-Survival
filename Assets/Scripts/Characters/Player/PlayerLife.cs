using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : CharacterLife
{
    public override void OnDeathComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}