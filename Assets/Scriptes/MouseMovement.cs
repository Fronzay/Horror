using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [SerializeField] float mouseSensitivity;

    float xRotation;

    [SerializeField] Transform pBody;


    public void LateUpdate()
    {
        InputManager();
    }

    public void InputManager()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        pBody.Rotate(Vector3.up * MouseX);

        Cursor.lockState = CursorLockMode.Locked;

    }
}
