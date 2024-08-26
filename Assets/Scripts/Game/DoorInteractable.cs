using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    public string interactionPrompt => "Open Door";
    [SerializeField] DoorTeleport doorTP;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public bool Interact(Interactor interactor)
    {
        doorTP.LoadNextScene();
        gameManager.GetPlayer();
        return true;
    }
}
