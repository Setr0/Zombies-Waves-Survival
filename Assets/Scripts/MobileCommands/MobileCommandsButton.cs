using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileCommandsButton : MonoBehaviour
{
    [SerializeField] Text buttonText;

    void Start()
    {
        if (PlayerPrefs.GetInt("Mobile Commands", 0) == 0)
        {
            buttonText.text = "ENABLE MOBILE COMMANDS";
        }
        else
        {
            buttonText.text = "DISABLE MOBILE COMMANDS";
        }
    }

    public void HandleMobileCommands()
    {
        if (PlayerPrefs.GetInt("Mobile Commands", 0) == 0)
        {
            PlayerPrefs.SetInt("Mobile Commands", 1);

            buttonText.text = "DISABLE MOBILE COMMANDS";
        }
        else
        {
            PlayerPrefs.SetInt("Mobile Commands", 0);

            buttonText.text = "ENABLE MOBILE COMMANDS";
        }
    }
}
