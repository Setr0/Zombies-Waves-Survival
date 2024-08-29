using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponBox : MonoBehaviour
{
    public Weapon weapon;

    [SerializeField] Image weaponImage;

    public void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;

        weaponImage.sprite = weapon.spriteRenderer.sprite;
        weaponImage.color = new Color(1f, 1f, 1f, 1f);
    }
}
