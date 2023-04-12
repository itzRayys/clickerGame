using UnityEngine;

public class interactableTeleport : MonoBehaviour
{
    public moveToMouse playerMove;
    public interactableObjectEnabler objectEnabler;


    [Space(15)]
    public Transform playerPosition;
    public Transform cameraPosition;

    [Space(15)]
    public Vector2 teleportLocation;
    public float teleportMarkerRadius;
    public Vector2 cameraTeleportLocation;
    public float cameraTeleportMarkerRadius;

    private bool isTriggering = false;
    private bool isTeleporting = false;


    private void Update()
    {
        if (isTriggering && !isTeleporting && Input.GetMouseButtonDown(0))
        {
            teleport();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered collider");
        if (collision != null)
        {
            isTriggering = true;
            objectEnabler.showPopupObjects();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isTriggering = false;
        Debug.Log("Exited collider");
        objectEnabler.hidePopupObjects();
    }


    private void teleport()
    {
        Debug.Log("Player teleporting");
        isTeleporting = true;
        playerMove.isMove = false;
        objectEnabler.setObjects();
        playerPosition.position = teleportLocation;
        cameraPosition.position = new Vector3(cameraTeleportLocation.x, 
            cameraTeleportLocation.y, -10f);
        isTeleporting = false;
        Debug.Log("Player teleported successfully");
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(new Vector3(teleportLocation.x, teleportLocation.y, 0), 
            teleportMarkerRadius);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(new Vector3(cameraTeleportLocation.x, cameraTeleportLocation.y, 0),
            cameraTeleportMarkerRadius);
    }
}
