using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class itemDatabaseScript : MonoBehaviour
{
    public itemDatabase items;

    private static itemDatabaseScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void resetItemPurchases()
    {
        foreach (var item in instance.items.listOfItems)
        {
            item.isOwned = false;
        }
        Debug.Log("Purchases reset!");
    }
    public void unlockAllItems()
    {
        foreach (var item in instance.items.listOfItems)
        {
            item.isOwned = true;
        }
        Debug.Log("All items unlocked!");
    }
}
