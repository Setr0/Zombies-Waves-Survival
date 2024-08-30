using UnityEngine;

public class MobileCommands : MonoBehaviour
{
    [SerializeField] GameObject mobileCommandsPanel;

    public static bool areEnabled;

    void Awake()
    {
        areEnabled = PlayerPrefs.GetInt("Mobile Commands", 0) == 1;

        if (!areEnabled) mobileCommandsPanel.SetActive(false);
    }
}