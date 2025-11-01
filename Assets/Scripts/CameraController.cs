using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;

    public GameObject pauseMenu;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void LateUpdate()
    {
        if (!pauseMenu.activeSelf)
        { 
            Vector3 cameraPosition = player.position + Vector3.up * 2f;
            transform.position = cameraPosition;

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            cameraVerticalRotation -= mouseY;
            cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);

            transform.localEulerAngles = new Vector3(cameraVerticalRotation, player.eulerAngles.y, 0f);

            player.Rotate(Vector3.up * mouseX);
        }
    }
}
