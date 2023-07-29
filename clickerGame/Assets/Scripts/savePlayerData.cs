using UnityEngine;

[System.Serializable]
public class savePlayerData
{
    public string currentLocation;
    public int woofCount;
    public int moneyCount;
    public string[] itemsEquipped;
    public bool[] itemsUnlocked;

    private int itemCount;

    //script checks current player data to be sent to formatter for saving
    public savePlayerData(mapManager map, countInt count, itemManager item)
    {
        //sets last location + woof and money counts
        currentLocation = map.currentLocation;
        woofCount = count.woofCount;
        moneyCount = count.moneyCount;

        //sets item array lengths
        //6 equipped for the 6 slots + one bool for each item that exists
        itemsEquipped = new string[6];
        itemsUnlocked = new bool[item.itemDatabase.listOfItems.Count];

        //counter to match item spot in list to bool[] spot
        itemCount = 0;

        //loops through each item in the itemDatabase
        foreach (itemSO itemSO in item.itemDatabase.listOfItems)
        {
            //checks if item exists
            if (itemSO != null)
            {
                //records if item is unlocked
                itemsUnlocked[itemCount] = unlockedCheck(itemSO);

                //saves item names to appropriate slot
                if (equippedCheck(itemSO))
                {
                    itemsEquipped[(itemSO as itemSOClothing).itemSlot] = itemSO.itemName;
                    Debug.Log(itemSO.itemName + " is equipped.");
                }
            }

            //break in case item == null
            else
            {
                break;
            }

            //keeps count of item slot in database
            itemCount++;
        }

    }

    //checks clothing items and returns if equipped or not for saving
    private bool equippedCheck(itemSO itemSO)
    {
        if (itemSO is itemSOClothing && (itemSO as itemSOClothing).isEquipped)
        {
            return true;
        }
        return false;
    }

    //returns whether item is owned or not
    private bool unlockedCheck(itemSO itemSO)
    {
        if (itemSO.isOwned)
        {
            return true;
        }
        return false;
    }
}
