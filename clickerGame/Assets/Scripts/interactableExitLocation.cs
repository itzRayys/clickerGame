using UnityEngine;

public class interactableExitLocation : MonoBehaviour
{
    public menuManager menuManager;
    public interactableObjectEnabler objectEnabler;


    private bool isTriggering = false;


    private void Update()
    {
        if (isTriggering && Input.GetMouseButtonDown(0))
        {
            exitToMap();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            isTriggering = true;
            objectEnabler.showPopupObjects();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            isTriggering = false;
            objectEnabler.hidePopupObjects();
        }
    }
    private void exitToMap()
    {
        menuManager.openMap();
        objectEnabler.setObjects();
        isTriggering = false;
    }

}
