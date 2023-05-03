using UnityEngine;

public class interactableExitLocation : MonoBehaviour
{
    public menuManager menuManager;
    public mapManager mapManager;
    public interactableObjectEnabler objectEnabler;

    private float timeToExit;
    private float exitTimer;

    private bool isExiting = false;
    private bool isTriggering = false;
    private bool isMovePause = false;


    private void Start()
    {
        timeToExit = mapManager.timeToExit;
        exitTimer = timeToExit;
    }

    private void Update()
    {
        if (isTriggering && Input.GetMouseButton(1))
        {
            isExiting = true;
            if (menuManager.playerMove.isMove)
            {
                menuManager.playerMove.isMove = false;
                isMovePause = true;
            }
            exitTimer -= Time.deltaTime;
            Debug.Log(exitTimer);
            if (exitTimer <= 0)
            {
                exitToMap();
                resetExit();
            }
        }
        if (isExiting && Input.GetMouseButtonUp(1))
        {
            isExiting = false;
            resetExit();
            if (isMovePause)
            {
                menuManager.playerMove.isMove = true;
                isMovePause = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            isTriggering = true;
            objectEnabler.showPopupObjects();
            resetExit();
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            isTriggering = false;
            resetExit();
            objectEnabler.hidePopupObjects();
        }
    }
    private void resetExit()
    {
        isExiting = false;
        exitTimer = timeToExit;
    }
    private void exitToMap()
    {
        menuManager.openMap();
        objectEnabler.setObjects();
        objectEnabler.hidePopupObjects();
        menuManager.playerMove.isMove = false;
        isTriggering = false;
        isExiting = false;
        isMovePause = false;
    }
}
