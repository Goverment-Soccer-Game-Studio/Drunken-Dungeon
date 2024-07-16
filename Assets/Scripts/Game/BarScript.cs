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
    [Header("Player Attributes")]
    [SerializeField] Camera playerCamera;
    [SerializeField] InputManager inputManager;

    public string interactionPrompt => "F Interact";

    public bool Interact(Interactor interactor)
    {
        //Disable the player controls and turn off the player camera
        inputManager.EnablePlayerInput(false);
        playerCamera.enabled = false;
        barAnimator.SetTrigger("BarInteract");
        return true;
    }
}
