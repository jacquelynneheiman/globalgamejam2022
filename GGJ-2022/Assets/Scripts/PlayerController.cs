using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    CharacterController characterController;

    // Start is called before the first frame update
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Move(horizontalInput, verticalInput);
    }

    public void Move(float horizontal, float vertical)
    {
        float forwardMovement = vertical * moveSpeed;
        float lateralMovement = horizontal * moveSpeed;
        Vector3 moveVector = new Vector3(lateralMovement, 0, forwardMovement);
        characterController.SimpleMove(moveVector);
    }
}
