using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour, IInteractable
{
    //Bar attributes
    [Header("Bar Items")]
    [SerializeField] Camera barCamera;
    [SerializeField] GameObject[] allBarDrinks;
    [SerializeField] GameObject[] activeBarDrinks;

    public string interactionPrompt => throw new System.NotImplementedException();

    public bool Interact(Interactor interactor)
    {
        throw new System.NotImplementedException();
    }
}
