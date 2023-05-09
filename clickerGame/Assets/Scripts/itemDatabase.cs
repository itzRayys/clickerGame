using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Database", menuName = "Scriptable Objects/New Item Database")]
public class itemDatabase : ScriptableObject
{
    public List<itemSO> listOfItems;


    public List<itemSOClothing> itemListHeadwear;
    public List<itemSOClothing> itemListTops;
    public List<itemSOClothing> itemListBottoms;
    public List<itemSOClothing> itemListFootwear;
    public List<itemSOClothing> itemListAccessories;


    public void fillItemLists()
    {
        Debug.Log("Starting item list sorting.");
        clearItemLists();
        float currentItemCount = 0;
        foreach (var item in listOfItems)
        {
            currentItemCount++;
            if (item is itemSOClothing)
            {
                itemSOClothing currentItem = item as itemSOClothing;
                switch (currentItem.itemSlot)
                {
                    case 0:
                        itemListHeadwear.Add((itemSOClothing)item);
                        break;
                    case 1:
                        itemListTops.Add((itemSOClothing)item);
                        break;
                    case 2:
                        itemListBottoms.Add((itemSOClothing)item);
                        break;
                    case 3:
                        itemListFootwear.Add((itemSOClothing)item);
                        break;
                    case 4:
                        itemListAccessories.Add((itemSOClothing)item);
                        break;
                    default:
                        break;
                }
            }
            Debug.Log((currentItemCount / listOfItems.Count) * 100 + "%");
        }
        Debug.Log("Items sorted!");
    }
    private void clearItemLists()
    {
        itemListHeadwear.Clear();
        itemListTops.Clear();
        itemListBottoms.Clear();
        itemListFootwear.Clear();
        itemListAccessories.Clear();
    }
}
