using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class shopManager : MonoBehaviour
{

    public countInt countInt;
    public textUpdate textUpdate;
    public itemManager itemDatabase;
    public Sprite placeholderSprite;
    public GameObject closeShopButton;
    public GameObject closeSubshopButton;

    private string loadedItemList;
    public List<itemSO> selectedList;

    [Space(10)]
    [Header("Shop Panels")]
    public GameObject[] shopPanelGO;
    public shopTemplates[] shopPanels;
    public Button[] shopPanelButtons;

    [Space(15)]
    [Header("Submenu")]
    public GameObject itemScrollPanel;
    public GameObject submenuScrollPanel;
    public Button[] submenuButtons;

    [Space(15)]
    [Header("Position")]
    public ScrollRect shopItemScrollRect;
    public ScrollRect shopSubmenuScrollRect;


    public void loadSubshop(int buttonNumber)
    {
        if (selectedList.Count > 0)
        {
            selectedList.Clear();
        }
        switch (buttonNumber)
        {
            case 0:
                selectedList = itemDatabase.itemDatabase.itemListHeadwear.Cast<itemSO>().ToList();
                loadSelectedShopItems(selectedList);
                loadedItemList = "Headwear";
                Debug.Log("Loaded Headwear Subshop!");
                break;
            case 1:
                selectedList = itemDatabase.itemDatabase.itemListHeadwear.Cast<itemSO>().ToList();
                loadSelectedShopItems(selectedList);
                loadedItemList = "Tops";
                Debug.Log("Loaded Tops Subshop!");
                break;
            case 2:
                selectedList = itemDatabase.itemDatabase.itemListBottoms.Cast<itemSO>().ToList();
                loadSelectedShopItems(selectedList);
                loadedItemList = "Bottoms";
                Debug.Log("Loaded Bottoms Subshop!");
                break;
            case 3:
                selectedList = itemDatabase.itemDatabase.itemListFootwear.Cast<itemSO>().ToList();
                loadSelectedShopItems(selectedList);
                loadedItemList = "Footwear";
                Debug.Log("Loaded Footwear Subshop!");
                break;
            case 4:
                selectedList = itemDatabase.itemDatabase.itemListAccessories.Cast<itemSO>().ToList();
                loadSelectedShopItems(selectedList);
                loadedItemList = "Accessories";
                Debug.Log("Loaded Accessories Subshop!");
                break;

            default:
                Debug.LogError("This subshop doesn't exist yet!");
                break;
        }

    }
    public void closeSubshop()
    {
        itemScrollPanel.SetActive(false);
        closeSubshopButton.SetActive(false);
        resetScrollPositions();
        submenuScrollPanel.SetActive(true);
        closeShopButton.SetActive(true);
    }
    private void loadSelectedShopItems(List<itemSO> selectedShopItems)
    {
        if (selectedShopItems.Count <= shopPanelGO.Length)
        {
            setItemInfo(selectedShopItems);
            affordCheck(selectedShopItems);
            setPanelsActive(selectedShopItems);
            resetScrollPositions();
            setSubshopActive();
        }
        else
        {
            Debug.LogError("Not enough shop panels to load " + selectedShopItems.ToString());
        }

    }
    private void setItemInfo(List<itemSO> selectedShopItems)
    {
        for (int i = 0; i < selectedShopItems.Count; i++)
        {
            shopPanels[i].itemName.text = selectedShopItems[i].itemName;
            shopPanels[i].itemCost.text = selectedShopItems[i].itemCost.ToString();
            if (selectedShopItems[i].itemIcon)
            {
                shopPanels[i].itemImage.sprite = selectedShopItems[i].itemIcon;
            }
            else
            {
                shopPanels[i].itemImage.sprite = placeholderSprite;
                Debug.LogWarning(selectedShopItems[i].itemName + " is missing an item sprite");
            }
        }
    }
    private void affordCheck(List<itemSO> selectedShopItems)
    {
        for (int i = 0; i < selectedShopItems.Count; i++)
        {
            if (selectedShopItems[i].itemCost <= countInt.moneyCount)
            {
                shopPanelButtons[i].interactable = true;
            }
            else
            {
                shopPanelButtons[i].interactable = false;
            }
        }
    }
    private void setPanelsActive(List<itemSO> selectedShopItems)
    {
        for (int i = 0; i < shopPanelGO.Length; i++)
        {
            shopPanelGO[i].SetActive(false);
        }
        for (int i = 0; i < selectedShopItems.Count; i++)
        {
            if (!selectedShopItems[i].isOwned)
            {
                shopPanelGO[i].SetActive(true);
            }
            else
            {
                shopPanelGO[i].SetActive(false);
            }
        }
    }
    public void resetScrollPositions()
    {
        shopItemScrollRect.horizontalNormalizedPosition = 0;
        shopSubmenuScrollRect.horizontalNormalizedPosition = 0;
    }
    private void setSubshopActive()
    {
        submenuScrollPanel.SetActive(false);
        itemScrollPanel.SetActive(true);
        closeShopButton.SetActive(false);
        closeSubshopButton.SetActive(true);
    }
    public void purchaseItem(int buttonNumber)
    {
        switch (loadedItemList)
        {
            case "Headwear":
                purchaseItemWork(selectedList, buttonNumber);
                break;
            case "Tops":
                purchaseItemWork(selectedList, buttonNumber);
                break;
            case "Bottoms":
                purchaseItemWork(selectedList, buttonNumber);
                break;
            case "Footwear":
                purchaseItemWork(selectedList, buttonNumber);
                break;
            case "Accessories":
                purchaseItemWork(selectedList, buttonNumber);
                break;

            default:
                break;
        }

    }
    private void purchaseItemWork(List<itemSO> selectedItems, int buttonNumber)
    {
        if (selectedItems[buttonNumber].itemCost <= countInt.moneyCount)
        {
            selectedItems[buttonNumber].isOwned = true;
            countInt.moneyCount -= selectedItems[buttonNumber].itemCost;
            textUpdate.updateMoneyText();
            shopPanels[buttonNumber].itemBuyButton.interactable = false;
            shopPanels[buttonNumber].itemCost.text = "Purchased!";
            Debug.Log(selectedItems[buttonNumber].itemName
                + " purchased! Current balance: "
                + countInt.moneyCount.ToString());
        }
        else
        {
            Debug.LogWarning("Player does not have enough money to purchase this item.");
            return;
        }
    }







    /*
    public countInt countInt;
    public textUpdate textUpdate;
    public Sprite placeholderSprite;
    public GameObject closeShopButton;
    public GameObject closeSubshopButton;
    private string loadedItemList;

    [Space(10)]
    [Header("Shop Panels")]
    public GameObject[] shopPanelGO;
    public shopTemplates[] shopPanels;
    public Button[] shopPanelButtons;

    [Space(15)]
    [Header("Submenu")]
    public GameObject itemScrollPanel;
    public GameObject submenuScrollPanel;
    public Button[] submenuButtons;

    [Space(15)]
    [Header("Item Lists")]
    public itemSO[] itemArrayHeadwear;
    public itemSO[] itemArrayTops;
    public itemSO[] itemArrayBottoms;
    public itemSO[] itemArrayFootwear;
    public itemSO[] itemArrayAccessories;

    [Space(15)]
    [Header("Position")]
    public ScrollRect shopItemScrollRect;
    public ScrollRect shopSubmenuScrollRect;


    public void loadSubshop(int buttonNumber)
    {
        switch (buttonNumber)
        {
            case 0:
                loadSelectedShopItems(itemArrayHeadwear);
                loadedItemList = "Headwear";
                Debug.Log("Loaded Headwear Subshop!");
                break;
            case 1:
                loadSelectedShopItems(itemArrayTops);
                loadedItemList = "Tops";
                Debug.Log("Loaded Tops Subshop!");
                break;
            case 2:
                loadSelectedShopItems(itemArrayBottoms);
                loadedItemList = "Bottoms";
                Debug.Log("Loaded Bottoms Subshop!");
                break;
            case 3:
                loadSelectedShopItems(itemArrayFootwear);
                loadedItemList = "Footwear";
                Debug.Log("Loaded Footwear Subshop!");
                break;
            case 4:
                loadSelectedShopItems(itemArrayAccessories);
                loadedItemList = "Accessories";
                Debug.Log("Loaded Accessories Subshop!");
                break;

            default:
                Debug.LogError("This subshop doesn't exist yet!");
                break;
        }
    }
    public void closeSubshop()
    {
        itemScrollPanel.SetActive(false);
        closeSubshopButton.SetActive(false);
        resetScrollPositions();
        submenuScrollPanel.SetActive(true);
        closeShopButton.SetActive(true);
    }
    private void loadSelectedShopItems(itemSO[] selectedShopItems)
    {
        if (selectedShopItems.Length <= shopPanelGO.Length)
        {
            setItemInfo(selectedShopItems);
            affordCheck(selectedShopItems);
            setPanelsActive(selectedShopItems);
            resetScrollPositions();
            setSubshopActive();
        }
        else
        {
            Debug.LogError("Not enough shop panels to load " + selectedShopItems.ToString());
        }

    }
    private void setItemInfo(itemSO[] selectedShopItems)
    {
        for (int i = 0; i < selectedShopItems.Length; i++)
        {
            shopPanels[i].itemName.text = selectedShopItems[i].itemName;
            shopPanels[i].itemCost.text = selectedShopItems[i].itemCost.ToString();
            if (selectedShopItems[i].itemIcon)
            {
                shopPanels[i].itemImage.sprite = selectedShopItems[i].itemIcon;
            }
            else
            {
                shopPanels[i].itemImage.sprite = placeholderSprite;
                Debug.LogWarning(selectedShopItems[i].itemName + " is missing an item sprite");
            }
        }
    }
    private void affordCheck(itemSO[] selectedShopItems)
    {
        for (int i = 0; i < selectedShopItems.Length; i++)
        {
            if (selectedShopItems[i].itemCost <= countInt.moneyCount)
            {
                shopPanelButtons[i].interactable = true;
            }
            else
            {
                shopPanelButtons[i].interactable = false;
            }
        }
    }
    private void setPanelsActive(itemSO[] selectedShopItems)
    {
        for (int i = 0; i < shopPanelGO.Length; i++)
        {
            shopPanelGO[i].SetActive(false);
        }
        for (int i = 0; i < selectedShopItems.Length; i++)
        {
            if (!selectedShopItems[i].isOwned)
            {
                shopPanelGO[i].SetActive(true);
            }
            else
            {
                shopPanelGO[i].SetActive(false);
            }
        }
    }
    public void resetScrollPositions()
    {
        shopItemScrollRect.horizontalNormalizedPosition = 0;
        shopSubmenuScrollRect.horizontalNormalizedPosition = 0;
    }
    private void setSubshopActive()
    {
        submenuScrollPanel.SetActive(false);
        itemScrollPanel.SetActive(true);
        closeShopButton.SetActive(false);
        closeSubshopButton.SetActive(true);
    }
    public void purchaseItem(int buttonNumber)
    {
        switch (loadedItemList)
        {
            case "Headwear":
                purchaseItemWork(itemArrayHeadwear, buttonNumber);
                break;
            case "Tops":
                purchaseItemWork(itemArrayTops, buttonNumber);
                break;
            case "Bottoms":
                purchaseItemWork(itemArrayBottoms, buttonNumber);
                break;
            case "Footwear":
                purchaseItemWork(itemArrayFootwear, buttonNumber);
                break;
            case "Accessories":
                purchaseItemWork(itemArrayAccessories, buttonNumber);
                break;

            default:
                break;
        }

    }
    private void purchaseItemWork(itemSO[] selectedItems, int buttonNumber)
    {
        if (selectedItems[buttonNumber].itemCost <= countInt.moneyCount)
        {
            selectedItems[buttonNumber].isOwned = true;
            countInt.moneyCount -= selectedItems[buttonNumber].itemCost;
            textUpdate.updateMoneyText();
            shopPanels[buttonNumber].itemBuyButton.interactable = false;
            shopPanels[buttonNumber].itemCost.text = "Purchased!";
            Debug.Log(selectedItems[buttonNumber].itemName
                + " purchased! Current balance: "
                + countInt.moneyCount.ToString());
        }
        else
        {
            Debug.LogWarning("Player does not have enough money to purchase this item.");
            return;
        }
    }
    */
}
