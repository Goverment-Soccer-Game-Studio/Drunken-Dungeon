using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] public Movement movement;
    [SerializeField] MouseCamera mouseCamera;
    [SerializeField] FightControls fightControls;
    [SerializeField] Interactor interactor;
    [SerializeField] BarControls barControls;

    //Player Controls
    PlayerControls playerControls;
    PlayerControls.GroundMovementActions groundMovementActions;
    PlayerControls.FightActions fightActions;
    PlayerControls.BarControlsActions barActions;

    //Bool to see if the player can move or use their camera
    bool canMove = true;
    public bool gamePaused = false;
    public bool inInteraction = false;
    Camera playerCam;
    Camera interactionCam;

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
        barActions = playerControls.BarControls;

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

            fightControls.RecieveInputL(fightActions.LeftPunch.triggered);
            fightControls.RecieveInputR(fightActions.RightPunch.triggered);
            interactor.InteractRecieveInput(playerControls.Interact.Interact.triggered);
        }

        if (barControls != null)
        {
            if (barControls.isActiveAndEnabled && !movement.isActiveAndEnabled)
            {
                barControls.RecieveInputL(barActions.SelectionLeft.triggered);
                barControls.RecieveInputR(barActions.SelectionRight.triggered);
                barControls.RecieveInputConfirm(barActions.Confirm.triggered);
                barControls.RecieveInputEscape(barActions.Escape.triggered);
            }
        }

        //Pause & Interaction controls
        if (playerControls.Escape.Escape.triggered && !inInteraction)
        {
            if (!gamePaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        gamePaused = true;
        canMove = false;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ResumeGame()
    {
        canMove = true;
        gamePaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Player input to use by other scripts.
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
