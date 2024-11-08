
using UnityEngine;

public class VRExperience : MonoBehaviour
{
    public GameObject[] pointsOfInterest; // Virtual travel or sightseeing POIs
    private int currentPOI = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Replace with VR controller input
        {
            // Move to the next POI or reset to the first one
            currentPOI = (currentPOI + 1) % pointsOfInterest.Length;
            MoveToPOI(pointsOfInterest[currentPOI]);
        }
    }

    void MoveToPOI(GameObject poi)
    {
        // Teleport the user to the POI location
        transform.position = poi.transform.position + Vector3.up * 2; // Adjust height
    }
}
