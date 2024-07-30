using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControls : MonoBehaviour
{

    bool drinkInputR;
    bool drinkInputL;
    bool confirmBool;
    [Header("Drinks")]
    [SerializeField] GameObject[] drinks;
    private int selectedDrink = 0;
    [SerializeField] Camera barCamera;

    private void Update()
    {
        barCamera.transform.LookAt(drinks[selectedDrink].transform.position);
        if (drinkInputR && selectedDrink != (drinks.Length - 1))
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
            Debug.Log("Drink Selected");
        }
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
}
