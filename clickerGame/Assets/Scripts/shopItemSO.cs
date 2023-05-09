using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/New Shop Item", fileName = "Shop Item")]
public class shopItemSO : ScriptableObject
{
    public string itemName;
    public Sprite itemSprite;
    public int itemCost;
    public int itemID;
    public string itemType;
    public bool isOwned = false;
    public bool isEquipped = false;
}
