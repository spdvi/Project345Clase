using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float deltaX, deltaY;
    public float rotateSpeed = 1f;

    // Cached reference
    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // NOOOO playerRb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        deltaY = Input.GetAxis("Mouse Y");
        deltaX = Input.GetAxis("Mouse X");

        // Mirar amunt i abaix rotar camera sobre su eje x
        transform.Rotate(-Vector3.right, deltaY * rotateSpeed);

        Vector3 angleRot = Vector3.up * deltaX * rotateSpeed;
        Quaternion rotation = Quaternion.Euler(angleRot);
        playerRb.MoveRotation(playerRb.rotation * rotation);
    }
}
