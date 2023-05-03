using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerEquippedItems : MonoBehaviour
{
    [Space(15)]
    [Header("Headpiece")]
    public string equippedHeadpieceName;
    public Sprite equippedHeadpieceSprite;
    public Vector2 equippedHeadpiecePosition;

    [Space(15)]
    [Header("Top")]
    public string equippedTopName;
    public Sprite equippedTopSprite;
    public Vector2 equippedTopPosition;

    [Space(15)]
    [Header("Bottom")]
    public string equippedBottomName;
    public Sprite equippedBottomSprite;
    public Vector2 equippedBottomPosition;

    [Space(15)]
    [Header("Footwear")]
    public string equippedFootwearName;
    public Sprite equippedFootwearSprite;
    public Vector2 equippedFootwearPosition;

    [Space(15)]
    [Header("Accessory 1")]
    public string equippedAccessory1Name;
    public Sprite equippedAccessory1Sprite;
    public Vector2 equippedAccessory1Position;

    [Space(15)]
    [Header("Accessory 2")]
    public string equippedAccessory2Name;
    public Sprite equippedAccessory2Sprite;
    public Vector2 equippedAccessory2Position;


}
