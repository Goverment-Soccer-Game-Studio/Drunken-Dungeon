using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BarControls : MonoBehaviour
{

    bool drinkInputR;
    bool drinkInputL;
    bool confirmBool;
    bool escapeBool;
    [SerializeField] BarScript barScript;
    [Header("Drinks")]
    public int selectedDrink = 0;

    private void Update()
    {
        if (drinkInputR && selectedDrink != (barScript.drinks.Length - 1))
        {
            Debug.Log("Right Drink");
            selectedDrink++;
            drinkInputR = false;
        }
        if (drinkInputL && selectedDrink != 0)
        {
            Debug.Log("Left Drink");
            selectedDrink--;
            drinkInputL = false;
        }
        if (confirmBool)
        {
            //Add UI controls stuff
            barScript.AddDrink(selectedDrink);
            Debug.Log("Drink Selected");
        }
        if (escapeBool)
        {
            barScript.EndBarInteraction();
            escapeBool = false;
        }

        barScript.SetDrinkText(selectedDrink);
    }

    public void RecieveInputR(bool dInput)
    {
        drinkInputR = dInput;
    }

    public void RecieveInputL(bool dInput)
    {
        drinkInputL = dInput;
    }

    public void RecieveInputConfirm(bool dInput)
    {
        confirmBool = dInput;
    }

    public void RecieveInputEscape(bool dInput)
    {
        escapeBool = dInput;
    }
}
