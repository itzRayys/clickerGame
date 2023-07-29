using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class savesPreview : MonoBehaviour
{
    public GameObject saveDogPreview;
    public TextMeshProUGUI saveNameText;
    public TextMeshProUGUI savePlaytimeText;
    public TextMeshProUGUI saveDateCreatedText;

    [Space(15)]
    public Button saveButtonHeart;
    public Button saveButtonPlay;
    public Button saveButtonDuplicate;
    public Button saveButtonDelete;
    public bool isHearted = false;
}
