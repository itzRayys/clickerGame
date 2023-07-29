using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleMenuManager : MonoBehaviour
{
    public titleSettingsScript settingsScript;
    public savesScript savesScript;

    public GameObject mainMenuGO;
    public GameObject savesMenuGO;
    public GameObject exitConfirmation;
    public GameObject settingsMenu;
    public GameObject settingsSaveMenu;


    public void playGame()
    {
        mainMenuGO.SetActive(false);
        savesScript.resetScrollPositions();
        savesMenuGO.SetActive(true);
    }
    public void backToMainMenu()
    {
        savesMenuGO.SetActive(false);
        mainMenuGO.SetActive(true);
    }

    public void openExitConfirmation()
    {
        exitConfirmation.SetActive(true);
    }
    public void closeExitConfirmation()
    {
        exitConfirmation.SetActive(false);
    }
    public void exitGame()
    {
        Debug.Log("Closing game... byebye!!");
        Application.Quit();
    }

    public void openSettings()
    {
        settingsMenu.SetActive(true);
    }
    public void closeSettings()
    {
        if (settingsScript.isSettingsChanged)
        {
            settingsSaveMenu.SetActive(true);
        }
        else
        {
            settingsMenu.SetActive(false);
        }
    }
    public void settingsSaveApply()
    {
        settingsScript.saveSettings();
    }
    public void settingsSaveApplyAndClose()
    {
        settingsScript.saveSettings();
        settingsSaveMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }
    public void settingsSaveClose()
    {
        settingsSaveMenu.SetActive(false);
    }
    public void settingsSaveIgnoreAndClose()
    {
        settingsScript.onRestoredOrSavedSettings();
        settingsSaveMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }
}
