using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapManager : MonoBehaviour
{
    public mapChanger mapChanger;


    [Space(15)]
    [Header("Info")]
    public string currentLocation;
    public float timeToExit;


    [Space(15)]
    [Header("Arrays")]
    public mapLocations[] mapLocations;
    public mapButtonHover[] mapButtonHover;


    private int mapCurrentCount;

    public void Awake()
    {
        foreach (var mapLocation in mapLocations) 
        {
            if (mapLocation.locationGO.activeSelf)
            {
                currentLocation = mapLocation.locationName;
                mapLocation.isCurrentLocation = true;
                Debug.Log("Current location: " + mapLocation.locationName);
            }
            else
            {
                mapLocation.isCurrentLocation = false;
            }
        }
    }
}
