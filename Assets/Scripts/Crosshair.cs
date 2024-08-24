using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public static Crosshair Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    Animator animator;
    Camera mainCamera;

    void Start()
    {
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;

        Cursor.visible = false;
    }

    void Update()
    {
        transform.position = new Vector2(mainCamera.ScreenToWorldPoint(Input.mousePosition).x, mainCamera.ScreenToWorldPoint(Input.mousePosition).y);

        transform.Rotate(0, 0, 1);
    }

    public void SetHitted()
    {
        animator.SetTrigger("Hitted");
    }

    public void SetKilled()
    {
        animator.SetTrigger("Killed");
    }
}
