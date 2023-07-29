using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class itemManager : MonoBehaviour
{
    public itemDatabase itemDatabase;

    private static itemManager instance;

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
    private void Start()
    {
        itemDatabase.fillItemLists();
    }
    public void resetItemPurchases()
    {
        foreach (var item in itemDatabase.listOfItems)
        {
            item.isOwned = false;
        }
        Debug.Log("Purchases reset!");
    }
    public void unlockAllItems()
    {
        foreach (var item in itemDatabase.listOfItems)
        {
            item.isOwned = true;
        }
        Debug.Log("All items unlocked!");
    }
}
