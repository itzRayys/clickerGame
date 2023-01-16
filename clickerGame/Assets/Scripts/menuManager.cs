using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    public GameObject gameMenu;
    public GameObject shopMenu;
    public shopManager shopManager;



    public void openShop()
    {
        gameMenu.SetActive(false);
        shopManager.affordCheck();
        shopMenu.SetActive(true);
    }

    public void closeShop()
    {
        shopMenu.SetActive(false);
        gameMenu.SetActive(true);
    }
}
