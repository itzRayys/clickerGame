using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{

    public shopManager shopManager;
    public itemManager itemDatabase;
    public int loadedSubinventory;

    public List<itemSO> selectedList;
    

    [Space(15)]
    [Header("Arrays")]
    public GameObject[] inventoryPanelsGO;
    public inventoryItemTemplate[] inventoryPanels;
    public Button[] itemEquipButtons;


    [Space(15)]
    [Header("Game Objects")]
    public GameObject inventorySubmenuGO;
    public GameObject inventorySubinventoryGO;
    public GameObject inventoryCloseButton;
    public GameObject inventoryBackButton;


    [Space(15)]
    [Header("Positions")]
    public ScrollRect inventorySubmenuScroll;
    public ScrollRect inventoryItemScroll;


    public void loadSubinventory(int buttonNumber)
    {
        if (selectedList.Count > 0)
        {
            selectedList.Clear();
        }
        switch (buttonNumber)
        {
            case 0:
                selectedList = itemDatabase.itemDatabase.itemListHeadwear.Cast<itemSO>().ToList();
                loadSubinventoryItems(selectedList);
                loadedSubinventory = 0;
                Debug.Log("Loaded headwear subinventory!");
                break;
            case 1:
                selectedList = itemDatabase.itemDatabase.itemListTops.Cast<itemSO>().ToList();
                loadSubinventoryItems(selectedList);
                loadedSubinventory = 1;
                Debug.Log("Loaded tops subinventory!");
                break;
            case 2:
                selectedList = itemDatabase.itemDatabase.itemListBottoms.Cast<itemSO>().ToList();
                loadSubinventoryItems(selectedList);
                loadedSubinventory = 2;
                Debug.Log("Loaded bottoms subinventory!");
                break;
            case 3:
                selectedList = itemDatabase.itemDatabase.itemListFootwear.Cast<itemSO>().ToList();
                loadSubinventoryItems(selectedList);
                loadedSubinventory = 3;
                Debug.Log("Loaded footwear subinventory!");
                break;
            case 4:
                selectedList = itemDatabase.itemDatabase.itemListAccessories.Cast<itemSO>().ToList();
                loadSubinventoryItems(selectedList);
                loadedSubinventory = 4;
                Debug.Log("Loaded accessories subinventory!");
                break;

            default:
                Debug.LogWarning("This subinventory doesn't exist yet!");
                break;
        }
    }

    private void loadSubinventoryItems(List<itemSO> selectedItems)
    {
        if (selectedItems.Count <= inventoryPanelsGO.Length)
        {
            setItemInfo(selectedItems);
            setPanelsActive(selectedItems);
            resetScrollPositions();
            setSubinventoryActive();
        }
        else
        {
            Debug.LogError("Not enough inventory panels to load " + selectedItems.ToString());
        }
    }
    private void setItemInfo(List<itemSO> selectedItems)
    {
        for (int i = 0; i < selectedItems.Count; i++)
        {
            inventoryPanels[i].itemSprite.sprite = selectedItems[i].itemIcon;
        }
    }
    private void setPanelsActive(List<itemSO> selectedItems)
    {
        for (int i = 0; i < inventoryPanelsGO.Length; i++)
        {
            inventoryPanelsGO[i].SetActive(false);
        }
        for (int i = 0; i < selectedItems.Count; i++)
        {
            if (selectedItems[i].isOwned)
            {
                inventoryPanelsGO[i].SetActive(true);
            }
            else
            {
                inventoryPanelsGO[i].SetActive(false);
            }
        }
    }
    public void resetScrollPositions()
    {
        inventoryItemScroll.verticalNormalizedPosition = 1;
        inventorySubmenuScroll.verticalNormalizedPosition = 1;
    }
    private void setSubinventoryActive()
    {
        inventorySubmenuGO.SetActive(false);
        inventoryCloseButton.SetActive(false);
        inventorySubinventoryGO.SetActive(true);
        inventoryBackButton.SetActive(true);
    }
    public void closeSubinventory()
    {
        inventorySubinventoryGO.SetActive(false);
        inventoryBackButton.SetActive(false);
        resetScrollPositions();
        inventorySubmenuGO.SetActive(true);
        inventoryCloseButton.SetActive(true);
    }
}
