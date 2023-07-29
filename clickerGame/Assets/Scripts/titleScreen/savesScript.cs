using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savesScript : MonoBehaviour
{
    public ScrollRect savesScrollRect;

    [Space(15)]
    [Header("Arrays")]
    public savesPreview[] savesPreviewScriptArray;
    public GameObject[] savesPreviewGOArray;


    private void Start()
    {
        resetScrollPositions();
    }

    public void resetScrollPositions()
    {
        savesScrollRect.verticalNormalizedPosition = 1;
    }

    public void heartSave(int buttonNumber)
    {

    }
    public void loadSave(int buttonNumber)
    {

    }
    public void duplicateSave(int buttonNumber)
    {

    }
    public void deleteSave(int buttonNumber)
    {

    }
}
