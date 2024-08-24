using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    public string interactionPrompt => "Open Door";
    [SerializeField] DoorTeleport doorTP;
    GameManager gameManager;
    PlayerUI playerUI;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerUI = GameObject.Find("OverlayCanvas").GetComponent<PlayerUI>();
    }

    public bool Interact(Interactor interactor)
    {
        playerUI.FadeScreen();
        doorTP.LoadNextScene();
        gameManager.GetPlayer();
        return true;
    }
}
