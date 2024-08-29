using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReloadingText : MonoBehaviour
{
    PlayerWeaponHandler playerWeaponHandler;

    TextMeshProUGUI reloadingText;

    void Awake()
    {
        playerWeaponHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerWeaponHandler>();

        reloadingText = GetComponent<TextMeshProUGUI>();
    }

    void OnEnable()
    {
        playerWeaponHandler.OnReloadingChanged += ReloadingChanged;
    }

    void OnDisable()
    {
        playerWeaponHandler.OnReloadingChanged -= ReloadingChanged;
    }

    void ReloadingChanged(bool isReloading)
    {
        if (isReloading)
        {
            reloadingText.text = "RELOADING...";
        }
        else
        {
            reloadingText.text = "";
        }
    }
}
