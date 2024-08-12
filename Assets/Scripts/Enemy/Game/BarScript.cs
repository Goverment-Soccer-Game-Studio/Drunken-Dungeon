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
    [SerializeField] BarControls barControls;
    [SerializeField] public GameObject[] drinks;
    private List<GameObject> finalDrink;
    [Header("Player Attributes")]
    [SerializeField] Camera playerCamera;
    [SerializeField] InputManager inputManager;
    [SerializeField] Animator playerAnimator;

    public string interactionPrompt => "F Interact";

    public bool Interact(Interactor interactor)
    {
        //Disable the player controls and turn off the player camera
        StartBarInteraction();
        barAnimator.SetTrigger("BarInteract");
        return true;
    }

    private void Update()
    {
        barCamera.transform.LookAt(drinks[barControls.selectedDrink].transform);
    }

    public bool StartBarInteraction()
    {
        Debug.Log("Start Bar Interact");
        finalDrink = new List<GameObject>();
        inputManager.EnablePlayerInput(false);
        barControls.enabled = true;
        barCamera.enabled = true;
        playerCamera.enabled = false;
        inputManager.inInteraction = true;
        inputManager.movement.enabled = false;
        return true;
    }

    public bool EndBarInteraction()
    {
        Debug.Log("End Bar Interact");
        inputManager.EnablePlayerInput(true);
        barControls.enabled = false;
        barCamera.enabled = false;
        playerCamera.enabled = true;
        inputManager.inInteraction = false;
        inputManager.movement.enabled = true;
        //playerAnimator.SetTrigger("AfterBar");
        return true;
    }

    public bool AddDrink(int i)
    {
        finalDrink.Add(drinks[i]);
        if (finalDrink.Count < 5)
        {
            Debug.Log("Drinks in: " + finalDrink.Count);
            return true;
        }
        else
        {
            foreach (var drink in finalDrink)
            {
                drink.GetComponent<IDrink>().OnDrink();
            }
            EndBarInteraction();
        }
        return false;
    }
}
