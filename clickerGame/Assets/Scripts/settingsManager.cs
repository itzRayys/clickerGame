using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsManager : MonoBehaviour
{
    public menuManager menuManager;
    public settingsVolumeChange settingsVolumeChange;
    







    [Space(15)]
    [Header("Settings Submenu Buttons")]
    public Button subSettingsVideoButton;
    public Button subSettingsAudioButton;
    public Button subSettingsInputButton;
    public Button subSettingsGameButton;
    public Button subSettingsAccessibilityButton;

    [Space(15)]
    [Header("Settings Submenu GOs")]
    public GameObject subSettingsVideoGO;
    public GameObject subSettingsAudioGO;
    public GameObject subSettingsInputGO;
    public GameObject subSettingsGameGO;
    public GameObject subSettingsAccessibilityGO;

    private int openedSubSettings;

    public void openSubSettings(int buttonNumber)
    {
        switch (buttonNumber)
        {
            case 0:
                closeSubSettings();
                subSettingsVideoGO.SetActive(true);
                subSettingsVideoButton.interactable = false;
                openedSubSettings = 0;
                break;
            case 1:
                closeSubSettings();
                subSettingsAudioGO.SetActive(true);
                subSettingsAudioButton.interactable = false;
                openedSubSettings = 1;
                break;
            case 2:
                closeSubSettings();
                subSettingsInputGO.SetActive(true);
                subSettingsInputButton.interactable = false;
                openedSubSettings = 2;
                break;
            case 3:
                closeSubSettings();
                subSettingsGameGO.SetActive(true);
                subSettingsGameButton.interactable = false;
                openedSubSettings = 3;
                break;
            case 4:
                closeSubSettings();
                subSettingsAccessibilityGO.SetActive(true);
                subSettingsAccessibilityButton.interactable = false;
                openedSubSettings = 4;
                break;
        }
    }
    public void closeSubSettings()
    {
        switch (openedSubSettings)
        {
            case 0:
                subSettingsVideoGO.SetActive(false);
                subSettingsVideoButton.interactable = true;
                break;
            case 1:
                subSettingsAudioGO.SetActive(false);
                subSettingsAudioButton.interactable = true;
                break;
            case 2:
                subSettingsInputGO.SetActive(false);
                subSettingsInputButton.interactable = true;
                break;
            case 3:
                subSettingsGameGO.SetActive(false);
                subSettingsGameButton.interactable = true;
                break;
            case 4:
                subSettingsAccessibilityGO.SetActive(false);
                subSettingsAccessibilityButton.interactable = true;
                break;
            default:
                Debug.LogError("This sub settings doesn't exist!");
                break;
        }
    }
    public void resetSettingsSubmenuSelection()
    {
        subSettingsVideoButton.interactable = false;
        subSettingsAudioButton.interactable = true;
        subSettingsInputButton.interactable = true;
        subSettingsGameButton.interactable = true;
        subSettingsAccessibilityButton.interactable = true;

        subSettingsVideoGO.SetActive(true);
        subSettingsAudioGO.SetActive(false);
        subSettingsInputGO.SetActive(false);
        subSettingsGameGO.SetActive(false);
        subSettingsAccessibilityGO.SetActive(false);

        openedSubSettings = 0;
    }
}
