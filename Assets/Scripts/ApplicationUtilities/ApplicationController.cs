using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationController : MonoBehaviour
{
    public int timeScale = 1;

    void Start()
    {
        Time.timeScale = timeScale;
        Application.targetFrameRate = 100;
    }

    public void SetTimeScale(int value = 1)
    {
        timeScale = value;
        Time.timeScale = timeScale;
    }
}
