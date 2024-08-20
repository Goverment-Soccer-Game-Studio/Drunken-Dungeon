using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField] GameObject barUI;
    [SerializeField] TMP_Text barUITxt;
    private List<GameObject> finalDrink;
    private bool barUsed = false;
    [Header("Player Attributes")]
    [SerializeField] Camera playerCamera;
    [SerializeField] InputManager inputManager;
    [SerializeField] Animator playerAnimator;

    public string interactionPrompt => "F Interact";

    public bool Interact(Interactor interactor)
    {
        //Disable the player controls and turn off the player camera
        if (!barUsed)
        {
            StartBarInteraction();
            barAnimator.SetTrigger("BarInteract");
        }
        return true;
    }

    private void Update()
    {
        barCamera.transform.LookAt(drinks[barControls.selectedDrink].transform);
    }

    public bool StartBarInteraction()
    {
        Debug.Log("Start Bar Interact");
        barUI.gameObject.SetActive(true);
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
        barUI.gameObject.SetActive(false);
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
            barUsed = true;
            EndBarInteraction();
        }
        return false;
    }

    public void SetDrinkText(int drink)
    {
        barUITxt.text = drinks[drink].GetComponent<IDrink>().drinkName + "\n\n" + drinks[drink].GetComponent<IDrink>().drinkDescription;
    }
}
