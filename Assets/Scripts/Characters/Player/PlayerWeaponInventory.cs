using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    public bool IsInPosses(string id)
    {
        for (int i = 0; i < weaponsInPosses.Count; i++)
        {
            if (weaponsInPosses[i].id == id)
            {
                return true;
            }
        }

        return false;
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

        if (weaponsInPosses.ElementAtOrDefault(index) == null || currentIndex == index) return;

        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].gameObject.SetActive(false);
        }

        playerWeaponHandler.currentWeapon = weaponsInPosses[index];
        playerWeaponHandler.canFire = true;
        weaponsInPosses[index].gameObject.SetActive(true);

        currentIndex = index;

        playerWeaponHandler.AmmosChanged();
    }
}
