using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    public string interactionPrompt => "Open Door";
    [SerializeField] DoorTeleport doorTP;

    public bool Interact(Interactor interactor)
    {
        doorTP.LoadRandomScene();
        return true;
    }
}
