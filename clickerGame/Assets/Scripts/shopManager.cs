using UnityEngine;
using UnityEngine.UI;

public class shopManager : MonoBehaviour
{
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
    public shopItemSO[] shopItemHeadwear;
    public shopItemSO[] shopItemBackground;
    public shopItemSO[] shopItemSO2;
    public shopItemSO[] shopItemSO3;

    [Space(15)]
    [Header("Position")]
    public ScrollRect shopItemScrollRect;
    public ScrollRect shopSubmenuScrollRect;


    public void loadSubshop(int buttonNumber)
    {
        switch (buttonNumber)
        {
            case 0:
                loadSelectedShopItems(shopItemHeadwear);
                loadedItemList = "Headwear";
                Debug.Log("Loaded Headwear Subshop!");
                break;
            case 1:
                loadSelectedShopItems(shopItemBackground);
                loadedItemList = "Backgrounds";
                Debug.Log("Loaded Background Subshop!");
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
    private void loadSelectedShopItems(shopItemSO[] selectedShopItems)
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
    private void setItemInfo(shopItemSO[] selectedShopItems)
    {
        for (int i = 0; i < selectedShopItems.Length; i++)
        {
            shopPanels[i].itemName.text = selectedShopItems[i].itemName;
            shopPanels[i].itemCost.text = selectedShopItems[i].itemCost.ToString();
            if (selectedShopItems[i].itemSprite)
            {
                shopPanels[i].itemImage.sprite = selectedShopItems[i].itemSprite;
            }
            else
            {
                shopPanels[i].itemImage.sprite = placeholderSprite;
                Debug.LogWarning(selectedShopItems[i].itemName + " is missing an item sprite");
            }
        }
    }
    private void affordCheck(shopItemSO[] selectedShopItems)
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
    private void setPanelsActive(shopItemSO[] selectedShopItems)
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
                purchaseItemWork(shopItemHeadwear, buttonNumber);
                break;
            case "Backgrounds":
                purchaseItemWork(shopItemBackground, buttonNumber);
                break;

            default:
                break;
        }

    }
    private void purchaseItemWork(shopItemSO[] selectedItems, int buttonNumber)
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
}
