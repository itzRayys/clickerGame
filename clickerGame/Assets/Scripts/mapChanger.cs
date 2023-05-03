using UnityEngine;

public class mapChanger : MonoBehaviour
{
    public mapManager mapManager;
    public menuManager menuManager;
    public moveToMouse playerController;
    public Transform playerTransform;


    private void Start()
    {
        setYouAreHere();
    }
    public void changeLocation(mapLocations targetLocation)
    {
        if (!targetLocation.isCurrentLocation && targetLocation.isUnlocked)
        {
            disableLocations();
            enableLocation(targetLocation);
            setDebugInfo(targetLocation);
            menuManager.closeMap();
            movePlayerToSpawnpoint(targetLocation);
        }
    }

    public void resetButtonState(mapButtonHover buttonHoverScript)
    {
        buttonHoverScript.buttonText.SetActive(false);
        buttonHoverScript.buttonImageGlow.SetActive(false);
        setYouAreHere();
    }


    private void setYouAreHere()
    {
        for (int i = 0; i < mapManager.mapButtonHover.Length; i++)
        {
            if (mapManager.mapLocations[i].isCurrentLocation)
            {
                mapManager.mapButtonHover[i].buttonYouAreHere.SetActive(true);
            }
            else
            {
                mapManager.mapButtonHover[i].buttonYouAreHere.SetActive(false);
            }
        }
    }
    private void disableLocations()
    {
        foreach(var location in mapManager.mapLocations)
        {
            location.isCurrentLocation = false;
            location.gameObject.SetActive(false);
        }
    }
    private void enableLocation(mapLocations targetLocation)
    {
        targetLocation.locationGO.SetActive(true);
        targetLocation.isCurrentLocation = true;
    }
    private void setDebugInfo(mapLocations targetLocation)
    {
        mapManager.currentLocation = targetLocation.locationName;
        Debug.Log("Travelled to: " + targetLocation.locationName);
    }
    private void movePlayerToSpawnpoint(mapLocations targetLocation)
    {
        playerController.isMove = false;
        playerTransform.position = targetLocation.locationSpawnpoint;
    }
}
