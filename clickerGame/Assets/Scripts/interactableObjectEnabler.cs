using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableObjectEnabler : MonoBehaviour
{
    public GameObject[] gameObjectsDisable;
    public GameObject[] gameObjectsEnable;
    public GameObject[] gameObjectsEnablePopup;



    public void setObjects()
    {
        foreach (GameObject obj in gameObjectsDisable)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
        foreach (GameObject obj in gameObjectsEnable)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }

    public void showPopupObjects()
    {
        foreach (GameObject obj in gameObjectsEnablePopup)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }
    public void hidePopupObjects()
    {
        foreach (GameObject obj in gameObjectsEnablePopup)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}
