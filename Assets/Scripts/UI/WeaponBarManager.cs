using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBarManager : MonoBehaviour
{
    PlayerWeaponInventory playerWeaponInventory;

    [SerializeField] WeaponBox[] weaponBoxes;

    void Awake()
    {
        playerWeaponInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerWeaponInventory>();
    }

    void OnEnable()
    {
        playerWeaponInventory.OnInventoryChanged += AllocateWeapon;
        playerWeaponInventory.OnSpaceSelected += SelectSpace;
    }

    void OnDisable()
    {
        playerWeaponInventory.OnInventoryChanged -= AllocateWeapon;
        playerWeaponInventory.OnSpaceSelected -= SelectSpace;
    }

    void AllocateWeapon(Weapon weapon)
    {
        for (int i = 0; i < weaponBoxes.Length; i++)
        {
            if (weaponBoxes[i].weapon == null)
            {
                weaponBoxes[i].SetWeapon(weapon);

                break;
            }
        }
    }

    void SelectSpace(int index)
    {
        for (int i = 0; i < weaponBoxes.Length; i++)
        {
            weaponBoxes[i].Select(i == index);
        }
    }
}
