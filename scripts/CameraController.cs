using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    private Vector3 offset; // Offset between the camera and the player

    void Start()
    {
        offset = transform.position - player.position; // Calculate the initial offset
    }

    void LateUpdate()
    {
        this.transform.position = player.position + offset; // Update the camera's position based on the player's position and the offset
    }
}
