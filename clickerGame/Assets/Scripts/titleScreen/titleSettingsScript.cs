using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titleSettingsScript : MonoBehaviour
{
    public Button applyChangesButton;
    public bool isSettingsChanged = false;
    public void saveSettings()
    {
        Debug.Log("Settings Saved!");
        onRestoredOrSavedSettings();
    }
    public void onChangedSettings()
    {
        isSettingsChanged = true;
        applyChangesButton.interactable = true;
    }
    public void onRestoredOrSavedSettings()
    {
        isSettingsChanged = false;
        applyChangesButton.interactable = false;
    }
}
