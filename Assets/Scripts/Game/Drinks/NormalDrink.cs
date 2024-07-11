using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDrink : MonoBehaviour, IInteractable
{

    public string interactionPrompt => "Sippy";

    public bool Interact(Interactor interactor)
    {
        return true;
    }
}
