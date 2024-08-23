using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        Cursor.visible = false;
    }

    void Update()
    {
        transform.position = new Vector2(mainCamera.ScreenToWorldPoint(Input.mousePosition).x, mainCamera.ScreenToWorldPoint(Input.mousePosition).y);

        transform.Rotate(0, 0, 1);
    }
}
