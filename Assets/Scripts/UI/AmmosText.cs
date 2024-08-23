using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmosText : MonoBehaviour
{
    PlayerWeaponHandler playerWeaponHandler;

    TextMeshProUGUI ammosText;

    void Start()
    {
        ammosText = GetComponent<TextMeshProUGUI>();
    }

    void Awake()
    {
        playerWeaponHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerWeaponHandler>();
    }

    void OnEnable()
    {
        playerWeaponHandler.OnAmmosChanged += UpdateText;
    }

    void OnDisable()
    {
        playerWeaponHandler.OnAmmosChanged -= UpdateText;
    }

    void UpdateText(int ammos, int ammosInUse)
    {
        ammosText.text = $"{ammos}/{ammosInUse}";
    }
}
