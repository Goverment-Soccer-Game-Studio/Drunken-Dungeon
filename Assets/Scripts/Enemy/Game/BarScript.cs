using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BarScript : MonoBehaviour, IInteractable
{
    //Bar attributes
    [Header("Bar Items")]
    [SerializeField] Camera barCamera;
    [SerializeField] Animator barAnimator;
    [SerializeField] GameObject[] allBarDrinks;
    [SerializeField] GameObject[] activeBarDrinks;
    [SerializeField] BarControls barControls;
    [Header("Player Attributes")]
    [SerializeField] Camera playerCamera;
    [SerializeField] InputManager inputManager;

    public string interactionPrompt => "F Interact";

    public bool Interact(Interactor interactor)
    {
        //Disable the player controls and turn off the player camera
        StartBarInteraction();
        barAnimator.SetTrigger("BarInteract");
        return true;
    }

    public bool EndBarInteraction()
    {
        inputManager.EnablePlayerInput(true);
        barControls.enabled = false;
        barCamera.enabled = false;
        playerCamera.enabled = true;
        inputManager.inInteraction = false;
        inputManager.movement.enabled = true;
        return true;
    }

    public void StartBarInteraction()
    {
        inputManager.EnablePlayerInput(false);
        inputManager.inInteraction = true;
        barCamera.enabled = true;
        playerCamera.enabled = false;
        barControls.enabled = true;
        inputManager.movement.enabled = false;
    }
}
