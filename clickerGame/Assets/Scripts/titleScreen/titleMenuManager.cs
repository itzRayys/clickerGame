using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleMenuManager : MonoBehaviour
{
    public GameObject exitConfirmation;
    public GameObject settingsMenu;
    public GameObject settingsSaveMenu;
    public titleSettingsScript settingsScript;

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
    public void closeSettingsUnchanged()
    {
        settingsMenu.SetActive(false);
    }
    public void closeSettingsChanged()
    {
        settingsSaveMenu.SetActive(true);
    }

    public void settingsSaveApply()
    {
        settingsScript.saveSettings();
        settingsSaveClose();
    }
    public void settingsSaveClose()
    {
        settingsSaveMenu.SetActive(false);
    }
}
