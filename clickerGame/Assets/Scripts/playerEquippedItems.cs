using UnityEngine;

public class playerEquippedItems : MonoBehaviour
{
    [Space(15)]
    [Header("Game Objects")]
    public GameObject headpieceGO;
    public GameObject topGO;
    public GameObject bottomGO;
    public GameObject footwearGO;
    public GameObject accessory1GO;
    public GameObject accessory2GO;

    [Space(15)]
    [Header("Headpiece")]
    public string equippedHeadpieceName;
    public itemSOClothing equippedHeadpieceSO;
    public Sprite equippedHeadpieceSprite;

    [Space(15)]
    [Header("Top")]
    public string equippedTopName;
    public itemSOClothing equippedTopSO;
    public Sprite equippedTopSprite;

    [Space(15)]
    [Header("Bottom")]
    public string equippedBottomName;
    public itemSOClothing equippedBottomSO;
    public Sprite equippedBottomSprite;

    [Space(15)]
    [Header("Footwear")]
    public string equippedFootwearName;
    public itemSOClothing equippedFootwearSO;
    public Sprite equippedFootwearSprite;

    [Space(15)]
    [Header("Accessory 1")]
    public string equippedAccessory1Name;
    public itemSOClothing equippedAccessory1SO;
    public Sprite equippedAccessory1Sprite;

    [Space(15)]
    [Header("Accessory 2")]
    public string equippedAccessory2Name;
    public itemSOClothing equippedAccessory2SO;
    public Sprite equippedAccessory2Sprite;


}
