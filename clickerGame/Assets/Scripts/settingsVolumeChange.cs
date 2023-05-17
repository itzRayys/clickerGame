using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class settingsVolumeChange : MonoBehaviour
{
    public audioManager audioManager;
    public Slider volumeSlider;
    public TextMeshProUGUI volumeSliderValueText;

    public void updateVolume()
    {
        volumeSliderValueText.text = volumeSlider.value.ToString();
        foreach (audioManager.sound sound in audioManager.soundEffects)
        {
            sound.volume = volumeSlider.value / 100;
        }
        audioManager.updateSoundVolumes();
    }
}
