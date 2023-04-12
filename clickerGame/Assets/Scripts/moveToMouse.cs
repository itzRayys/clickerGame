using UnityEngine;

public class moveToMouse : MonoBehaviour
{
    [Space(5)]
    [Header("Transforms")]
    public Transform playerPosition;
    public Transform playerSpritePosition;

    [Space(15)]
    [Header("Floats")]
    public float moveSpeedCloseClose;
    public float moveSpeedClose;
    public float moveSpeedFar;
    public float followToggleRadius = 0.25f;

    private float moveSpeed;
    public bool isMove = false;

    private void Update()
    {
        movePlayer();
        toggleMove();
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

        }
    }
    private void toggleMove()
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
}
