using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

//This code will be duplicated for each drink script, doing different things
public class BarSpeedUpDrink : MonoBehaviour, IInteractable, IDrink
{
    //Input for player animator, object, and data
    [SerializeField] private Animator playerAnimator;
    [SerializeField] GameObject playerDrinkHolder;
    [SerializeField] PlayerData playerData;
    public string drinkName => "Normal Drink";
    public string interactionPrompt => "Drink";
    //Set the inherited variables
    public Animator iAnimator => playerAnimator;
    public GameObject iDrinkHolder => playerDrinkHolder;
    public PlayerData iPlayerData => playerData;

    public string drinkDescription => "Do speed";

    public bool Interact(Interactor interactor)
    {
        //Drink when interacted
        OnDrink();
        return true;
    }

    public void OnDrink()
    {
        //Set the parent to the right hard
        //this.gameObject.transform.SetParent(iDrinkHolder.transform);
        //Move the drink to the right hand
        //this.gameObject.transform.position = iDrinkHolder.transform.position;
        //Play the animation
        //iAnimator.SetTrigger("Drink");
        Debug.Log(drinkName + " has been drunk");
        //Drink effects
        playerData.speed += 0.5f;
        //Destroy the drink
        //Destroy(this.gameObject, 0.5f);
    }
}