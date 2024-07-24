using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    //Center of the interaction sphere
    [SerializeField] private Transform interactPoint;
    //Radius of the interaction sphere
    [SerializeField] private float interactRadius = 0.5f;
    //The layer that the objects have to be on to be registered for the interaction sphere
    [SerializeField] private LayerMask interactMask;
    //The UI that is enabled or disabled if they are in range of the item.
    [SerializeField] private InteractionUI interactionUI;

    //Max things you can be collided with.
    private readonly Collider[] aColliders = new Collider[3];
    [SerializeField] private int numFound;

    private IInteractable interactable;

    //Input bool for if the interact button was pressed
    bool interactPressed;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactPoint.position, interactRadius, aColliders, interactMask);
        if (numFound > 0)
        {
            interactable = aColliders[0].GetComponent<IInteractable>();
            if (interactable != null)
            {
                if (!interactionUI.isDisplayed)
                {
                    interactionUI.Setup(interactable.interactionPrompt);

                }

                //Using the input manager changes the interactPressed Bool
                if (interactPressed)
                {
                    Debug.Log("Interact Pressed");
                    interactable.Interact(this);
                }
                interactPressed = false;
            }
        }
        else
        {
            if (interactable != null)
            {
                interactable = null;
            }

            if (interactionUI.isDisplayed)
            {
                interactionUI.Close();
            }
        }
    }

    public void InteractRecieveInput(bool input)
    {
        interactPressed = input;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactPoint.position, interactRadius);
    }
}
