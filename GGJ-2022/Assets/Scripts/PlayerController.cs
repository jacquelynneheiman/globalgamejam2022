using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float walkSpeed = 3f;
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float lookSpeed = 400f;
    [SerializeField] float rayRange = 4f;
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
        // TODO: Implement right joystick on gamepad.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Move(horizontalInput, verticalInput);

        // Interaction
        // TODO: Implement south face button
        if (Input.GetButtonDown("Interact"))
        {
            Interact();
        }

        if (Input.GetButtonDown("Pause"))
        {
            GameManager.Instance.TogglePause();
        }
    }

    public void Move(float horizontal, float vertical)
    {
        float moveSpeed;
        if (Input.GetButton("Run"))
        {
            moveSpeed = runSpeed;
        }
        else
        {
            moveSpeed = walkSpeed;
        }
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

    public void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.ScreenPointToRay(Input.mousePosition), out hit, rayRange))
        {
            IInteractible interactedObject = hit.transform.gameObject.GetComponent<IInteractible>();
            if (interactedObject != null)
            {
                interactedObject.Interact();
            }
        }
    }

}
