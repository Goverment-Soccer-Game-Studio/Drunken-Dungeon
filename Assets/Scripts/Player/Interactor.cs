using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform interactPoint;
    [SerializeField] private float interactRadius = 0.5f;
    [SerializeField] private LayerMask interactMask;
    [SerializeField] private InteractionUI interactionUI;

    //Max things you can be collided with.
    private readonly Collider[] aColliders = new Collider[3];
    [SerializeField] private int numFound;

    private IInteractable interactable;

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

                //Change for the new input manager
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Debug.Log("Interact Pressed");
                    interactable.Interact(this);
                }
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

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactPoint.position, interactRadius);
    }
}
