using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minZoomDistance = 2f;
    public float maxZoomDistance = 20f;

    public void ZoomIn()
    {
        Zoom(-1);
    }

    public void ZoomOut()
    {
        Zoom(1);
    }

    private void Zoom(int direction)
    {
        // Calculate the new zoom position
        Vector3 newPosition = transform.position + transform.forward * direction * zoomSpeed;

        // Clamp the zoom position to the defined min and max zoom distances
        newPosition = Vector3.ClampMagnitude(newPosition - transform.position, maxZoomDistance) + transform.position;
        newPosition = Vector3.ClampMagnitude(newPosition - transform.position, maxZoomDistance);

        // Set the new camera position
        transform.position = newPosition;
    }
}
