using UnityEngine;

public class mapLocations : MonoBehaviour
{
    public string locationName;
    public GameObject locationGO;
    public Vector2 locationSpawnpoint;
    public bool isUnlocked = false;
    public bool isCurrentLocation = false;


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(new Vector3(locationSpawnpoint.x, locationSpawnpoint.y, 0),
            0.13f);
    }
}
