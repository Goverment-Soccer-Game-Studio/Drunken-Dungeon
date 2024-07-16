using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] MouseCamera mouseCamera;
    [SerializeField] FightControls fightControls;
    [SerializeField] Interactor interactor;

    //Player Controls
    PlayerControls playerControls;
    PlayerControls.GroundMovementActions groundMovementActions;
    PlayerControls.FightActions fightActions;

    //Bool to see if the player can move or use their camera
    bool canMove = true;

    Vector2 wasdInput;
    Vector2 mouseInput;
    bool lPunch;
    bool rPunch;
    bool interact;

    private void Awake()
    {
        playerControls = new PlayerControls();
        groundMovementActions = playerControls.GroundMovement;
        fightActions = playerControls.Fight;

        groundMovementActions.Movement.performed += ctx => wasdInput = ctx.ReadValue<Vector2>();

        groundMovementActions.Jump.performed += _ => movement.OnJumpPressed();

        groundMovementActions.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovementActions.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void Update()
    {
        if (canMove)
        {
            movement.RecieveInput(wasdInput);
            mouseCamera.RecieveInput(mouseInput);

            //lPunch = fightActions.LeftPunch.triggered;
            //rPunch = fightActions.RightPunch.triggered;
            fightControls.RecieveInputL(fightActions.LeftPunch.triggered);
            fightControls.RecieveInputR(fightActions.RightPunch.triggered);
            interactor.InteractRecieveInput(playerControls.Interact.Interact.triggered);
        }
    }


    public void EnablePlayerInput(bool b)
    {
        canMove = b;
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
