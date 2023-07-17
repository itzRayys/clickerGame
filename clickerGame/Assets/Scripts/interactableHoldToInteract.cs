using UnityEngine;
using UnityEngine.Events;

public class interactableHoldToInteract : MonoBehaviour
{
    public interactableObjectEnabler objectEnabler;

    [Space(15)]
    public float timeToInteract;
    public UnityEvent onInteract;
    private float exitTimer;

    private menuManager menuManager;
    private bool isInteracting = false;
    private bool isTriggering = false;
    private bool isMovePause = false;
    
    private void Start()
    {
        menuManager = FindObjectOfType<menuManager>();
        exitTimer = timeToInteract;
    }

    private void Update()
    {
        if (isTriggering && Input.GetMouseButton(1))
        {
            isInteracting = true;
            if (menuManager.playerMove.isMove)
            {
                menuManager.playerMove.isMove = false;
                isMovePause = true;
            }
            exitTimer -= Time.deltaTime;
            Debug.Log(exitTimer);
            if (exitTimer <= 0)
            {
                onInteract.Invoke();
                objectEnabler.setObjects();
                objectEnabler.hidePopupObjects();
                menuManager.playerMove.isMove = false;
                isTriggering = false;
                isInteracting = false;
                isMovePause = false;
                resetExit();
            }
        }
        if (isInteracting && Input.GetMouseButtonUp(1))
        {
            isInteracting = false;
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
        isInteracting = false;
        exitTimer = timeToInteract;
    }
}
