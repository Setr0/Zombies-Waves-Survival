using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInventory : MonoBehaviour
{
    public delegate void InventoryHandler(Weapon weapon);
    public event InventoryHandler OnInventoryChanged;

    PlayerWeaponHandler playerWeaponHandler;

    [SerializeField] Weapon[] weapons;
    List<Weapon> weaponsInPosses;

    int currentIndex;

    void Start()
    {
        playerWeaponHandler = GetComponent<PlayerWeaponHandler>();

        weaponsInPosses = new List<Weapon>();

        AddWeapon(playerWeaponHandler.currentWeapon);

        currentIndex = 0;
    }

    public void AddWeapon(Weapon weapon)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i].id == weapon.id)
            {
                weaponsInPosses.Add(weapons[i]);
            }
        }

        OnInventoryChanged?.Invoke(weapon);
    }

    public void SelectWeapon(int index)
    {
        index -= 1;

        if (weaponsInPosses[index] == null || currentIndex == index) return;

        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].gameObject.SetActive(false);
        }

        playerWeaponHandler.currentWeapon = weaponsInPosses[index];
        weaponsInPosses[index].gameObject.SetActive(true);

        currentIndex = index;
    }
}
