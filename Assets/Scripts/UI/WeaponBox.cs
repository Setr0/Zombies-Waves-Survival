using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponBox : MonoBehaviour
{
    Image spaceImage;

    public bool isSelected = false;

    [Space(20)]
    [SerializeField] Sprite unselectedSprite;
    [SerializeField] Sprite selectedSprite;

    [Space(20)]
    public Weapon weapon;
    [SerializeField] Image weaponImage;

    void Start()
    {
        spaceImage = GetComponent<Image>();
    }

    public void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;

        weaponImage.sprite = weapon.spriteRenderer.sprite;
        weaponImage.color = new Color(1f, 1f, 1f, 1f);
    }

    public void Select(bool isSelected)
    {
        this.isSelected = isSelected;

        if (isSelected)
        {
            spaceImage.sprite = selectedSprite;
        }
        else
        {
            spaceImage.sprite = unselectedSprite;
        }
    }
}
