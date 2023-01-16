using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable Objects/New Shop Item", fileName = "Shop Item")]
public class shopItemSO : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int itemCost;
}
