using UnityEngine;

public class itemSO : ScriptableObject
{
    [Space(15)]
    [Header("General Item Info")]
    public string itemName;
    public Sprite itemIcon;
    public int itemCost;
    public int itemID;
    public bool isOwned = false;
}