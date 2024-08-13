using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public GameObject settingsMenu;  // Reference to the settings menu panel
    private bool InventoryOpen = false;

    public void OpenSettingsMenu()
    {
        settingsMenu.SetActive(true);  // Toggle the settings menu visibility
        Time.timeScale = 0f;  // Pause game mechanics
        InventoryOpen = true;
    }

    public void CloseSettingsMenu()
    {
        settingsMenu.SetActive(false);  // Hide the settings menu
        Time.timeScale = 1f;  // Resume game mechanics
        InventoryOpen = false;
    }
}
