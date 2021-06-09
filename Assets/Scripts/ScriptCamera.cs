using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamera : MonoBehaviour
{

    float mouseSensivity = 10f;

    [SerializeField]
    Transform playerBody;

    float xrotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity;

        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xrotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }

}
