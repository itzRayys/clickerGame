using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{

    public shopManager shopManager;
    

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
        switch (buttonNumber)
        {
            case 0:
                loadSubinventoryItems(shopManager.shopItemHeadwear);
                Debug.Log("Loaded headwear subinventory!");
                break;
            case 1:
                loadSubinventoryItems(shopManager.shopItemBackground);
                Debug.Log("Loaded background subinventory!");
                break;

            default:
                Debug.LogWarning("This subinventory doesn't exist yet!");
                break;
        }
    }

    private void loadSubinventoryItems(shopItemSO[] selectedItems)
    {
        if (selectedItems.Length <= inventoryPanelsGO.Length)
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
    private void setItemInfo(shopItemSO[] selectedItems)
    {
        for (int i = 0; i < selectedItems.Length; i++)
        {
            inventoryPanels[i].itemSprite.sprite = selectedItems[i].itemSprite;
        }
    }
    private void setPanelsActive(shopItemSO[] selectedItems)
    {
        for (int i = 0; i < inventoryPanelsGO.Length; i++)
        {
            inventoryPanelsGO[i].SetActive(false);
        }
        for (int i = 0; i < selectedItems.Length; i++)
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
