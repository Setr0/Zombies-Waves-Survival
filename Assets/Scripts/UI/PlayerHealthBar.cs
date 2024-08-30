using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    PlayerLife playerLife;

    Slider healthBar;

    void Awake()
    {
        playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
    }

    void Start()
    {
        healthBar = GetComponent<Slider>();

        healthBar.maxValue = playerLife.maxHealth;
        healthBar.value = playerLife.maxHealth;
    }

    void OnEnable()
    {
        playerLife.OnDamaged += UpdateHealthBar;
        playerLife.OnDied += UpdateHealthBar;
        playerLife.OnTookHealth += UpdateHealthBar;
    }

    void OnDisable()
    {
        playerLife.OnDamaged -= UpdateHealthBar;
        playerLife.OnDied -= UpdateHealthBar;
        playerLife.OnTookHealth -= UpdateHealthBar;
    }

    void UpdateHealthBar(float health)
    {
        healthBar.value = health;
    }
}
