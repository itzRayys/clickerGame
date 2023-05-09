using UnityEngine;

public class moveToMouse : MonoBehaviour
{
    [Space(5)]
    [Header("Transforms")]
    public Transform playerPosition;
    public Transform playerSpritePosition;
    public Transform playerClothingHeadpieceSprite;
    public Transform playerClothingTopSprite;
    public Transform playerClothingBottomSprite;
    public Transform playerClothingFootwearSprite;
    public Transform playerClothingAccessory1Sprite;
    public Transform playerClothingAccessory2Sprite;

    [Space(15)]
    [Header("Floats")]
    public float moveSpeedCloseClose;
    public float moveSpeedClose;
    public float moveSpeedFar;
    public float followToggleRadius = 0.25f;

    [Space(15)]
    [Header("Other")]
    public bool isMove = false;
    public menuManager menuManager;
    public playerEquippedItems playerEquippedItems;
    private float moveSpeed;

    private void Update()
    {
        toggleMove();
        movePlayer();
    }


    private void movePlayer()
    {
        if (isMove)
        {
            var targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float distanceToMove = Vector2.Distance(playerPosition.position, targetPosition);
            switch (distanceToMove)
            {
                case float n when (n < 1):
                    moveSpeed = moveSpeedCloseClose;
                    break;
                case float n when (n < 2 && n >= 1):
                    moveSpeed = moveSpeedClose;
                    break;
                case float n when (n >= 2):
                    moveSpeed = moveSpeedFar;
                    break;
                default:
                    break;
            }
            playerPosition.position = Vector2.MoveTowards(playerPosition.position,
                targetPosition, moveSpeed * Time.deltaTime);
            playerSpritePosition.position = playerPosition.position;
            playerClothingHeadpieceSprite.position = playerPosition.position +
                playerEquippedItems.equippedHeadpiecePosition;
            playerClothingTopSprite.position = playerPosition.position +
                playerEquippedItems.equippedTopPosition;
            playerClothingBottomSprite.position = playerPosition.position +
                playerEquippedItems.equippedBottomPosition;
            playerClothingFootwearSprite.position = playerPosition.position +
                playerEquippedItems.equippedFootwearPosition;
            playerClothingAccessory1Sprite.position = playerPosition.position +
                playerEquippedItems.equippedAccessory1Position;
            playerClothingAccessory2Sprite.position = playerPosition.position +
                playerEquippedItems.equippedAccessory2Position;
        }
    }
    public void toggleMove()
    {
        if (!menuManager.isMenuOpened)
        {
            if (Vector2.Distance(playerPosition.position,
                Camera.main.ScreenToWorldPoint(Input.mousePosition))
                <= followToggleRadius && Input.GetMouseButtonDown(0))
            {
                if (isMove)
                {
                    isMove = false;
                }
                else
                {
                    isMove = true;
                }
            }
        }
        else
        {
            isMove = false;
        }
    }

}
