using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerLife playerLife;

    [SerializeField] GameObject playerPanel;
    [SerializeField] GameObject gameoverPanel;

    void Awake()
    {
        playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
    }

    void OnEnable()
    {
        playerLife.OnDied += Gameover;
    }

    void OnDisable()
    {
        playerLife.OnDied -= Gameover;
    }

    void Gameover(float health)
    {
        Time.timeScale = 0;

        Cursor.visible = true;

        playerPanel.SetActive(false);
        gameoverPanel.SetActive(true);
    }
}
