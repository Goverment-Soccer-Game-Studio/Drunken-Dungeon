using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTestBlock : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string interactionPrompt => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("You have interacted with cube johnson");
        return true;
    }
}
