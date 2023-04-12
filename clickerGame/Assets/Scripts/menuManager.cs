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


    [Space(10)]
    [Header("Managers")]
    public shopManager shopManager;
    public inventoryManager inventoryManager;


    [Space(10)]
    [Header("References")]
    public moveToMouse playerMove;



    public void openShop()
    {
        disableMovement();
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
        disableMovement();
        gameMenu.SetActive(false);
        inventoryManager.resetScrollPositions();
        inventoryMenu.SetActive(true);
    }
    public void closeInventory()
    {
        inventoryMenu.SetActive(false);
        gameMenu.SetActive(true);
    }


    public void openMap()
    {
        disableMovement();
        gameMenu.SetActive(false);
        mapMenu.SetActive(true);
    }
    public void closeMap()
    {
        mapMenu.SetActive(false);
        gameMenu.SetActive(true);
    }


    private void disableMovement()
    {
        playerMove.isMove = false;
    }
    private void enableMovement()
    {
        playerMove.isMove = true;
    }
}
