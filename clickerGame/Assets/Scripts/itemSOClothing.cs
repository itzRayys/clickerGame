using UnityEngine;


[CreateAssetMenu(fileName = "itemClothing", menuName = "Scriptable Objects/New Clothing")]
public class itemSOClothing : itemSO
{
    [Space(15)]
    [Header("Clothing Info")]
    public Sprite itemSprite;
    public Vector2 itemPosition;
    public Vector2 itemRotation;
    public Vector2 itemScale;
    public int itemSlot;
    public bool isEquipped = false;
}