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
    public Vector3 equippedHeadpiecePosition;
    public Vector2 equippedHeadpieceRotation;
    public Vector2 equippedHeadpieceScale;

    [Space(15)]
    [Header("Top")]
    public string equippedTopName;
    public itemSOClothing equippedTopSO;
    public Sprite equippedTopSprite;
    public Vector3 equippedTopPosition;
    public Vector2 equippedTopRotation;
    public Vector2 equippedTopScale;

    [Space(15)]
    [Header("Bottom")]
    public string equippedBottomName;
    public itemSOClothing equippedBottomSO;
    public Sprite equippedBottomSprite;
    public Vector3 equippedBottomPosition;
    public Vector2 equippedBottomRotation;
    public Vector2 equippedBottomScale;

    [Space(15)]
    [Header("Footwear")]
    public string equippedFootwearName;
    public itemSOClothing equippedFootwearSO;
    public Sprite equippedFootwearSprite;
    public Vector3 equippedFootwearPosition;
    public Vector2 equippedFootwearRotation;
    public Vector2 equippedFootwearScale;

    [Space(15)]
    [Header("Accessory 1")]
    public string equippedAccessory1Name;
    public itemSOClothing equippedAccessory1SO;
    public Sprite equippedAccessory1Sprite;
    public Vector3 equippedAccessory1Position;
    public Vector2 equippedAccessory1Rotation;
    public Vector2 equippedAccessory1Scale;

    [Space(15)]
    [Header("Accessory 2")]
    public string equippedAccessory2Name;
    public itemSOClothing equippedAccessory2SO;
    public Sprite equippedAccessory2Sprite;
    public Vector3 equippedAccessory2Position;
    public Vector2 equippedAccessory2Rotation;
    public Vector2 equippedAccessory2Scale;


}
