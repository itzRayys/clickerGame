using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class settingsTextUpdate : MonoBehaviour
{
    public settingsVolumeChange settingsVolumeChange;


    public TextMeshProUGUI settingsVolumeValueText;

    public void updateSettingsText()
    {
        settingsVolumeValueText.text = settingsVolumeChange.volumeSlider.value.ToString();
    }
}
