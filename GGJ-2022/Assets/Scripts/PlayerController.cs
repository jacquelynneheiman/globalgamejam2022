using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] float lookSpeed = 400f;
    float verticalRotation = 0f;

    CharacterController characterController;
    Camera playerCamera;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();
        if (playerCamera == null) { Debug.LogWarning("[PlayerController] couldn't find player camera."); }
        verticalRotation = playerCamera.transform.localRotation.x;
    }

    private void Update()
    {
        // Movement
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Look(mouseX, mouseY);

        // Mouse Look
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Move(horizontalInput, verticalInput);
    }

    public void Move(float horizontal, float vertical)
    {
        Vector3 forwardMovement = vertical * moveSpeed * transform.forward;
        Vector3 lateralMovement = horizontal * moveSpeed * transform.right;
        Vector3 moveVector = forwardMovement + lateralMovement;
        characterController.SimpleMove(moveVector);
    }

    public void Look(float horizontal, float vertical)
    {
        Vector3 horizontalRotateVector = Vector3.up * horizontal * lookSpeed * Time.deltaTime;
        transform.Rotate(horizontalRotateVector, Space.Self);

        verticalRotation -= vertical * lookSpeed * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
