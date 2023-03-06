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


    [Space(10)]
    [Header("Managers")]
    public shopManager shopManager;
    public inventoryManager inventoryManager;



    public void openShop()
    {
        gameMenu.SetActive(false);
        shopManager.resetScrollPositions();
        shopMenu.SetActive(true);
    }

    public void closeShop()
    {
        shopMenu.SetActive(false);
        gameMenu.SetActive(true);
    }

    
    public void openInventory()
    {
        gameMenu.SetActive(false);
        inventoryManager.resetScrollPositions();
        inventoryMenu.SetActive(true);
    }


    public void closeInventory()
    {
        inventoryMenu.SetActive(false);
        gameMenu.SetActive(true);
    }
}
