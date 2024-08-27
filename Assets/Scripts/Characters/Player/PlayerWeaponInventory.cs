using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInventory : MonoBehaviour
{
    PlayerWeaponHandler playerWeaponHandler;

    List<Weapon> weapons;

    void Start()
    {
        playerWeaponHandler = GetComponent<PlayerWeaponHandler>();

        weapons = new List<Weapon>(){
            playerWeaponHandler.currentWeapon
        };
    }

    public void AddWeapon(Weapon weapon)
    {
        weapons.Add(weapon);
    }
}
