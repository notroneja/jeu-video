using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 300f;

    public Transform playerBody;

    float XRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(mouseSensitivity);
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;//* Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity; //* Time.deltaTime;

        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
