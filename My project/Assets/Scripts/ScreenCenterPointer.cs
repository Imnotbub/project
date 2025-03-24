using UnityEngine;

public class ScreenCenterPointer : MonoBehaviour
{
    public Transform targetObject; // Assign this in the Inspector

    void Update()
    {
        // Calculate the screen center in world coordinates
        Vector3 screenCenter = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane)); // Use nearClipPlane for consistent results

        // Make the object look at the screen center
        if (targetObject != null) {
            targetObject.LookAt(screenCenter);
        }
    }
}
