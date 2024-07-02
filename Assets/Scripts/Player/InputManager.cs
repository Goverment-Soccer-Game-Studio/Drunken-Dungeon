using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] MouseCamera mouseCamera;

    //Player Controls
    PlayerControls playerControls;
    PlayerControls.GroundMovementActions groundMovementActions;

    Vector2 wasdInput;
    Vector2 mouseInput;

    private void Awake()
    {
        playerControls = new PlayerControls();
        groundMovementActions = playerControls.GroundMovement;

        groundMovementActions.Movement.performed += ctx => wasdInput = ctx.ReadValue<Vector2>();

        groundMovementActions.Jump.performed += _ => movement.OnJumpPressed();

        groundMovementActions.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovementActions.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void Update()
    {
        movement.RecieveInput(wasdInput);
        mouseCamera.RecieveInput(mouseInput);
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
