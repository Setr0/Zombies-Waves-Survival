using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInventory : MonoBehaviour
{
    public delegate void InventoryHandler(Weapon weapon);
    public event InventoryHandler OnInventoryChanged;

    PlayerWeaponHandler playerWeaponHandler;

    List<Weapon> weapons;

    void Start()
    {
        playerWeaponHandler = GetComponent<PlayerWeaponHandler>();

        weapons = new List<Weapon>();

        AddWeapon(playerWeaponHandler.currentWeapon);
    }

    public void AddWeapon(Weapon weapon)
    {
        weapons.Add(weapon);

        OnInventoryChanged?.Invoke(weapon);
    }
}
