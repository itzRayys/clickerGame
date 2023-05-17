using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{


    [Space(10)]
    [Header("Menus")]
    public GameObject gameMenu;
    public GameObject shopMenu;
    public GameObject inventoryMenu;
    public GameObject mapMenu;
    public GameObject settingsMenu;


    [Space(10)]
    [Header("Managers")]
    public shopManager shopManager;
    public inventoryManager inventoryManager;
    public settingsManager settingsManager;


    [Space(10)]
    [Header("Other")]
    public moveToMouse playerMove;
    public bool isMenuOpened = false;


    // add something to disable movement when opening a menu
    // figure out exit timer in interactableExitLocation
    public void openShop()
    {
        gameMenu.SetActive(false);
        shopManager.resetScrollPositions();
        shopMenu.SetActive(true);
        isMenuOpened = true;
    }
    public void closeShop()
    {
        shopMenu.SetActive(false);
        gameMenu.SetActive(true);
        isMenuOpened = false;
    }


    public void openInventory()
    {
        gameMenu.SetActive(false);
        inventoryManager.resetScrollPositions();
        inventoryMenu.SetActive(true);
        isMenuOpened = true;
    }
    public void closeInventory()
    {
        inventoryMenu.SetActive(false);
        gameMenu.SetActive(true);
        isMenuOpened = false;
    }


    public void openMap()
    {
        gameMenu.SetActive(false);
        mapMenu.SetActive(true);
        isMenuOpened = true;
    }
    public void closeMap()
    {
        mapMenu.SetActive(false);
        gameMenu.SetActive(true);
        isMenuOpened = false;
    }


    public void openSettings()
    {
        gameMenu.SetActive(false);
        settingsManager.resetSettingsSubmenuSelection();
        settingsMenu.SetActive(true);
        isMenuOpened = true;
    }
    public void closeSettings()
    {
        settingsMenu.SetActive(false);
        gameMenu.SetActive(true);
        isMenuOpened = false;
    }
}
