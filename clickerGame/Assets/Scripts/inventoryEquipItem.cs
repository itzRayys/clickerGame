using UnityEditor.Search;
using UnityEngine;

public class inventoryEquipItem : MonoBehaviour
{
    public playerEquippedItems equippedItems;
    public inventoryManager inventoryManager;
    public shopManager shopManager;

    private int selectedItem;

    public void equipItem(int buttonNumber)
    {
        //input is number of inventory button
        //check which item[] is loaded
        //use input # to find the item in item[]
        //if !equipped, equip()
        //set other items !equipped, set this item equipped
        //use items stored info to set GO's sprite, pos, rot, size
        //NO ACTUALLY... split sprite into different parts
        //tail, legs, body (top and bottom maybe), collar, head, and ears?
        //folder or part[] of all sprites and just cycle/switch

        selectedItem = buttonNumber;
        switch (inventoryManager.loadedSubinventory)
        {
            case 0:


            default:
                Debug.Log("That subinventory doesn't exist!");
                break;
        }
    }

    private void selectItem(itemSO[] loadedSubinventory)
    {
        //loadedSubinventory[selectedItem]
    }
}
