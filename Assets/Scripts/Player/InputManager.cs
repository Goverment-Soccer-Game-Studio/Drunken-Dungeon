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
    [SerializeField] BarControls barControls;

    //Player Controls
    PlayerControls playerControls;
    PlayerControls.GroundMovementActions groundMovementActions;
    PlayerControls.FightActions fightActions;
    PlayerControls.BarControlsActions barActions;

    //Bool to see if the player can move or use their camera
    bool canMove = true;
    public bool gamePaused = false;
    bool inInteraction = false;
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
            }
        }

        //Pause & Interaction controls
        if (playerControls.Escape.Escape.triggered)
        {
            //If the game isnt paused but in an interaction, the player can press escape to leave the interaction
            if (!gamePaused)
            {
                if (inInteraction)
                {
                    canMove = true;
                    EndInteraction();
                    inInteraction = false;
                }
                //If the player isnt in an interaction and escape is pressed, it will pause the game.
                else
                {
                    PauseGame();
                }
            }
            //If the game is paused and the player presses escape, unpause the game.
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

    //If an interaction is started, set the bool to true so that it can disable the controls.
    public void StartInteraction(bool b)
    {
        inInteraction = b;
        movement.enabled = !b;
    }
    //If an interaction has a camera, you can disable the players camera and enable the interaction camera.
    public void StartInteraction(bool b, Camera pInteractionCam, Camera playerCamera)
    {
        inInteraction = b;
        playerCamera.enabled = !b;
        playerCam = playerCamera;
        pInteractionCam.enabled = b;
        interactionCam = pInteractionCam;
        movement.enabled = !b;
    }

    public void StartBarInteraction(bool b, Camera pInteractionCam, Camera playerCamera)
    {
        inInteraction = b;
        playerCamera.enabled = !b;
        playerCam = playerCamera;
        pInteractionCam.enabled = b;
        interactionCam = pInteractionCam;
        movement.enabled = !b;
        barControls.enabled = b;
    }

    //Disable the interaction camera, enables the player camera and sets it up for the next ineraction
    private void EndInteraction()
    {
        interactionCam.enabled = false;
        playerCam.enabled = true;
        interactionCam = null;
        playerCam = null;
        movement.enabled = true;
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
